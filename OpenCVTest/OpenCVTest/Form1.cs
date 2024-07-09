using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using OpenCvSharp;

namespace OpenCVTest
{
    public partial class Form1 : Form
    {
        private string[] selectedImageFiles;    // 선택한 이미지 파일들
        private string[] selectedCsvFile;       // 선택한 CSV 파일

        public Form1()
        {
            InitializeComponent();

            selectedImageFiles = null;
            selectedCsvFile = null;

            radio_GaussianFilter.Checked = true;
            radio_Canny.Checked = true;
        }

        private void imageSelectButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "이미지 파일|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            openFileDialog.Title = "이미지 파일을 선택하십시오.";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.selectedImageFiles = openFileDialog.FileNames;

                if (this.selectedImageFiles.Length != 0)
                {
                    imageSelectButton.ForeColor = System.Drawing.Color.White;
                    imageSelectButton.BackColor = System.Drawing.Color.Coral;
                }
                else
                {
                    imageSelectButton.ForeColor = System.Drawing.Color.Coral;
                    imageSelectButton.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void csvSelectButton_Click(object sender, EventArgs e)
        {
        }

        // 필터 - 엠보싱 필터 (radio_EmbossingFilter)
        public void filterEmbossing(Mat src, out Mat dst)
        {
            // 엠보싱 필터 마스크
            float[] kernelData =
                {
                    -1, -1, 0,
                    -1, 0, 1,
                    0, 1, 1
                };

            Mat emboss = new Mat(3, 3, MatType.CV_32FC1, kernelData);
            Mat output = new Mat();

            Cv2.Filter2D(src, output, -1, emboss, new Point(-1, -1), 128);

            dst = output.Clone();
        }

        // 필터 - 가우시안 필터 (radio_GaussianFilter)
        public void filterGaussian(Mat src, out Mat dst)
        {
            int sigma = 1;  // 가우시안 표준 편차
            Mat output = new Mat();

            Cv2.GaussianBlur(src, output, new OpenCvSharp.Size(), (double)sigma);

            dst = output.Clone();
        }

        // 필터 - 샤프닝 필터 (radio_SharpeningFilter)
        public void filterSharpening(Mat src, out Mat dst)
        {
            int sigma = 1;  // 가우시안 표준 편차
            Mat blurred = new Mat();

            Cv2.GaussianBlur(src, blurred, new OpenCvSharp.Size(), sigma);

            float alpha = 1.0f;
            dst = (1 + alpha * src - alpha * blurred);
        }

        // 필터 - 양방향 필터 (radio_BilateralFilter)
        public void filterBilateral(Mat src, out Mat dst)
        {
            // 색 공간의 표준 편차 는 10, 좌표 공간의 표준 편차는 5를 사용하는 양방향 필터를 수행
            Mat output = new Mat();
            Cv2.BilateralFilter(src, output, -1, 10, 5);

            dst = output.Clone();
        }

        // 필터 - 미디언 필터 (radio_MedianFilter)
        public void filterMedian(Mat src, out Mat dst)
        {
            Mat output = new Mat();
            Cv2.MedianBlur(src, output, 3);

            dst = output.Clone();
        }

        // 엣지 검출 - 소벳 엣지 검출 (radio_Sobel)
        public void detectSobelEdge(Mat src, out Mat dst)
        {
            Mat dx = new Mat();
            Mat dy = new Mat();
            Cv2.Sobel(src, dx, MatType.CV_32FC1, 1, 0);
            Cv2.Sobel(src, dy, MatType.CV_32FC1, 0, 1);

            Mat fmag = new Mat();
            Mat mag = new Mat();
            Cv2.Magnitude(dx, dy, fmag);
            fmag.ConvertTo(mag, MatType.CV_8UC1);

            Mat edge = new Mat();

            Cv2.Compare(mag, new Scalar(150), edge, CmpType.GT);

            dst = edge.Clone();
        }

        // 엣지 검출 - 캐니 엣지 검출 (radio_Canny)
        public void detectCannyEdge(Mat src, out Mat dst)
        {
            Mat output = new Mat();
            Cv2.Canny(src, output, 50, 150);

            dst = output.Clone();
        }

        // 직선 검출 - 허프 변환 (check_HoughLines)
        public void transformHoughLines(Mat src, out Mat dst)
        {
            // 라인 성분을 뽑아냄
            LineSegmentPoint[] lines = Cv2.HoughLinesP(src, 1, Math.PI / 180, 100, 100, 10);

            Mat output = new Mat();
            Cv2.CvtColor(src, output, ColorConversionCodes.GRAY2BGR);

            foreach(LineSegmentPoint line in lines)
            {
                Cv2.Line(output, line.P1, line.P2, new Scalar(0, 0, 255), 2);
            }

            dst = output.Clone();
        }

        // 사용자가 선택한 모든 필터를 적용함
        private void applyAllFilters(Mat src, out Mat dst)
        {
            Mat afterFilter = new Mat();
            Mat afterEdgeDetect = new Mat();
            Mat afterLineDetect = new Mat();

            // 필터
            if (radio_EmbossingFilter.Checked)  filterEmbossing(src, out afterFilter);
            if (radio_GaussianFilter.Checked)   filterGaussian(src, out afterFilter);
            if (radio_SharpeningFilter.Checked) filterSharpening(src, out afterFilter);
            if (radio_BilateralFilter.Checked)  filterBilateral(src, out afterFilter);
            if (radio_MedianFilter.Checked)     filterMedian(src, out afterFilter);

            // 엣지 검출
            if (radio_Sobel.Checked)    detectSobelEdge(afterFilter, out afterEdgeDetect);
            if (radio_Canny.Checked)    detectCannyEdge(afterFilter, out afterEdgeDetect);
            if (radio_NoEdge.Checked)   afterEdgeDetect = afterFilter.Clone();

            // 직선 검출
            if (check_HoughLines.Checked)
            {
                transformHoughLines(afterEdgeDetect, out afterLineDetect);
            }
            else
            {
                afterLineDetect = afterEdgeDetect.Clone();
            }                

            // 최종 결과물
            dst = afterLineDetect.Clone();
        }

        private void ImageViewButton_Click(object sender, EventArgs e)
        {
            if (this.selectedImageFiles != null)
            {
                // 선택한 이미지 파일들 중 1번째 것에 대해서만 결과를 창으로 보여줌
                string imagePath = this.selectedImageFiles[0];
                Mat beforeProcessImage = Cv2.ImRead(imagePath, ImreadModes.Grayscale);
                Mat afterProcessImage = new Mat();

                // 필터, 엣지 검출, 직선 검출 적용
                applyAllFilters(beforeProcessImage, out afterProcessImage);

                if (!afterProcessImage.Empty())
                    Cv2.ImShow("이미지 보여주기", afterProcessImage);
            }
        }

        private void ImageSaveButton_Click(object sender, EventArgs e)
        {
            if (this.selectedImageFiles != null)
            {
                // 선택한 이미지 파일들에 대해 결과를 파일로 저장함 (저장 경로를 사용자로부터 입력 받음)
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "파일을 저장할 폴더를 선택하세요.";
                    folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                    folderBrowserDialog.ShowNewFolderButton = true;

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = folderBrowserDialog.SelectedPath;
                        string appendedPath = "";

                        // selectedPath 아래에 디렉토리를 생성함
                        if (radio_EmbossingFilter.Checked) appendedPath += "엠보싱 필터 - ";
                        if (radio_GaussianFilter.Checked) appendedPath += "가우시안 필터 - ";
                        if (radio_SharpeningFilter.Checked) appendedPath += "샤프닝 필터 - ";
                        if (radio_BilateralFilter.Checked) appendedPath += "양방향 필터 - ";
                        if (radio_MedianFilter.Checked) appendedPath += "미디언 필터 - ";

                        if (radio_Sobel.Checked) appendedPath += "소벨 엣지 검출";
                        if (radio_Canny.Checked) appendedPath += "캐니 엣지 검출";
                        if (radio_NoEdge.Checked) appendedPath += "엣지 검출 안함";

                        if (check_HoughLines.Checked) appendedPath += " - 허브 변환";

                        string newFullPath = Path.Combine(selectedPath, appendedPath);

                        // 디렉토리가 존재하는지 확인
                        if (!Directory.Exists(newFullPath)) Directory.CreateDirectory(newFullPath);

                        // 새로 생성한 디렉토리에 필터, 엣지 검출, 직선 검출 적용한 결과물들을 저장함
                        foreach (string imagePath in selectedImageFiles)
                        {
                            Mat beforeProcessImage = Cv2.ImRead(imagePath, ImreadModes.Grayscale);
                            Mat afterProcessImage = new Mat();

                            // 필터, 엣지 검출, 직선 검출 적용
                            applyAllFilters(beforeProcessImage, out afterProcessImage);

                            if (!afterProcessImage.Empty())
                                Cv2.ImWrite(Path.Combine(newFullPath, Path.GetFileName(imagePath)), afterProcessImage);
                        }

                        MessageBox.Show("파일이 성공적으로 저장되었습니다: " + newFullPath);
                    }
                }
            }
        }
    }
}
