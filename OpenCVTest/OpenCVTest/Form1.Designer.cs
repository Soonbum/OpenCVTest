namespace OpenCVTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.imageSelectButton = new System.Windows.Forms.Button();
            this.ImageViewButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_MedianFilter = new System.Windows.Forms.RadioButton();
            this.radio_BilateralFilter = new System.Windows.Forms.RadioButton();
            this.radio_SharpeningFilter = new System.Windows.Forms.RadioButton();
            this.radio_GaussianFilter = new System.Windows.Forms.RadioButton();
            this.radio_EmbossingFilter = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_NoEdge = new System.Windows.Forms.RadioButton();
            this.radio_Canny = new System.Windows.Forms.RadioButton();
            this.radio_Sobel = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check_HoughLines = new System.Windows.Forms.CheckBox();
            this.ImageSaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이미지 선택";
            // 
            // imageSelectButton
            // 
            this.imageSelectButton.Location = new System.Drawing.Point(284, 12);
            this.imageSelectButton.Name = "imageSelectButton";
            this.imageSelectButton.Size = new System.Drawing.Size(106, 31);
            this.imageSelectButton.TabIndex = 4;
            this.imageSelectButton.Text = "파일 선택";
            this.imageSelectButton.UseVisualStyleBackColor = true;
            this.imageSelectButton.Click += new System.EventHandler(this.imageSelectButton_Click);
            // 
            // ImageViewButton
            // 
            this.ImageViewButton.Location = new System.Drawing.Point(125, 335);
            this.ImageViewButton.Name = "ImageViewButton";
            this.ImageViewButton.Size = new System.Drawing.Size(141, 31);
            this.ImageViewButton.TabIndex = 23;
            this.ImageViewButton.Text = "결과물 보기 (1개만)";
            this.ImageViewButton.UseVisualStyleBackColor = true;
            this.ImageViewButton.Click += new System.EventHandler(this.ImageViewButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_MedianFilter);
            this.groupBox1.Controls.Add(this.radio_BilateralFilter);
            this.groupBox1.Controls.Add(this.radio_SharpeningFilter);
            this.groupBox1.Controls.Add(this.radio_GaussianFilter);
            this.groupBox1.Controls.Add(this.radio_EmbossingFilter);
            this.groupBox1.Location = new System.Drawing.Point(30, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 92);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "필터 (택일)";
            // 
            // radio_MedianFilter
            // 
            this.radio_MedianFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_MedianFilter.AutoSize = true;
            this.radio_MedianFilter.Location = new System.Drawing.Point(121, 54);
            this.radio_MedianFilter.Name = "radio_MedianFilter";
            this.radio_MedianFilter.Size = new System.Drawing.Size(79, 22);
            this.radio_MedianFilter.TabIndex = 35;
            this.radio_MedianFilter.TabStop = true;
            this.radio_MedianFilter.Text = "미디언 필터";
            this.radio_MedianFilter.UseVisualStyleBackColor = true;
            // 
            // radio_BilateralFilter
            // 
            this.radio_BilateralFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_BilateralFilter.AutoSize = true;
            this.radio_BilateralFilter.Location = new System.Drawing.Point(29, 54);
            this.radio_BilateralFilter.Name = "radio_BilateralFilter";
            this.radio_BilateralFilter.Size = new System.Drawing.Size(79, 22);
            this.radio_BilateralFilter.TabIndex = 34;
            this.radio_BilateralFilter.TabStop = true;
            this.radio_BilateralFilter.Text = "양방향 필터";
            this.radio_BilateralFilter.UseVisualStyleBackColor = true;
            // 
            // radio_SharpeningFilter
            // 
            this.radio_SharpeningFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_SharpeningFilter.AutoSize = true;
            this.radio_SharpeningFilter.Location = new System.Drawing.Point(228, 21);
            this.radio_SharpeningFilter.Name = "radio_SharpeningFilter";
            this.radio_SharpeningFilter.Size = new System.Drawing.Size(79, 22);
            this.radio_SharpeningFilter.TabIndex = 33;
            this.radio_SharpeningFilter.TabStop = true;
            this.radio_SharpeningFilter.Text = "샤프닝 필터";
            this.radio_SharpeningFilter.UseVisualStyleBackColor = true;
            // 
            // radio_GaussianFilter
            // 
            this.radio_GaussianFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_GaussianFilter.AutoSize = true;
            this.radio_GaussianFilter.Location = new System.Drawing.Point(121, 21);
            this.radio_GaussianFilter.Name = "radio_GaussianFilter";
            this.radio_GaussianFilter.Size = new System.Drawing.Size(91, 22);
            this.radio_GaussianFilter.TabIndex = 32;
            this.radio_GaussianFilter.TabStop = true;
            this.radio_GaussianFilter.Text = "가우시안 필터";
            this.radio_GaussianFilter.UseVisualStyleBackColor = true;
            // 
            // radio_EmbossingFilter
            // 
            this.radio_EmbossingFilter.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_EmbossingFilter.AutoSize = true;
            this.radio_EmbossingFilter.Location = new System.Drawing.Point(29, 21);
            this.radio_EmbossingFilter.Name = "radio_EmbossingFilter";
            this.radio_EmbossingFilter.Size = new System.Drawing.Size(79, 22);
            this.radio_EmbossingFilter.TabIndex = 31;
            this.radio_EmbossingFilter.TabStop = true;
            this.radio_EmbossingFilter.Text = "엠보싱 필터";
            this.radio_EmbossingFilter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_NoEdge);
            this.groupBox2.Controls.Add(this.radio_Canny);
            this.groupBox2.Controls.Add(this.radio_Sobel);
            this.groupBox2.Location = new System.Drawing.Point(30, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 76);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "엣지 검출 (택일)";
            // 
            // radio_NoEdge
            // 
            this.radio_NoEdge.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_NoEdge.AutoSize = true;
            this.radio_NoEdge.Location = new System.Drawing.Point(228, 29);
            this.radio_NoEdge.Name = "radio_NoEdge";
            this.radio_NoEdge.Size = new System.Drawing.Size(95, 22);
            this.radio_NoEdge.TabIndex = 38;
            this.radio_NoEdge.TabStop = true;
            this.radio_NoEdge.Text = "엣지 검출 안함";
            this.radio_NoEdge.UseVisualStyleBackColor = true;
            // 
            // radio_Canny
            // 
            this.radio_Canny.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_Canny.AutoSize = true;
            this.radio_Canny.Location = new System.Drawing.Point(130, 29);
            this.radio_Canny.Name = "radio_Canny";
            this.radio_Canny.Size = new System.Drawing.Size(95, 22);
            this.radio_Canny.TabIndex = 37;
            this.radio_Canny.TabStop = true;
            this.radio_Canny.Text = "캐니 엣지 검출";
            this.radio_Canny.UseVisualStyleBackColor = true;
            // 
            // radio_Sobel
            // 
            this.radio_Sobel.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_Sobel.AutoSize = true;
            this.radio_Sobel.Location = new System.Drawing.Point(29, 29);
            this.radio_Sobel.Name = "radio_Sobel";
            this.radio_Sobel.Size = new System.Drawing.Size(95, 22);
            this.radio_Sobel.TabIndex = 36;
            this.radio_Sobel.TabStop = true;
            this.radio_Sobel.Text = "소벨 엣지 검출";
            this.radio_Sobel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_HoughLines);
            this.groupBox3.Location = new System.Drawing.Point(30, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 61);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "직선 검출 (토글)";
            // 
            // check_HoughLines
            // 
            this.check_HoughLines.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_HoughLines.AutoSize = true;
            this.check_HoughLines.Location = new System.Drawing.Point(29, 23);
            this.check_HoughLines.Name = "check_HoughLines";
            this.check_HoughLines.Size = new System.Drawing.Size(67, 22);
            this.check_HoughLines.TabIndex = 39;
            this.check_HoughLines.Text = "허프 변환";
            this.check_HoughLines.UseVisualStyleBackColor = true;
            // 
            // ImageSaveButton
            // 
            this.ImageSaveButton.Location = new System.Drawing.Point(284, 335);
            this.ImageSaveButton.Name = "ImageSaveButton";
            this.ImageSaveButton.Size = new System.Drawing.Size(106, 31);
            this.ImageSaveButton.TabIndex = 27;
            this.ImageSaveButton.Text = "결과물 저장";
            this.ImageSaveButton.UseVisualStyleBackColor = true;
            this.ImageSaveButton.Click += new System.EventHandler(this.ImageSaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 396);
            this.Controls.Add(this.ImageSaveButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImageViewButton);
            this.Controls.Add(this.imageSelectButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "결과물 생성";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button imageSelectButton;
        private System.Windows.Forms.Button ImageViewButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ImageSaveButton;
        private System.Windows.Forms.RadioButton radio_MedianFilter;
        private System.Windows.Forms.RadioButton radio_BilateralFilter;
        private System.Windows.Forms.RadioButton radio_SharpeningFilter;
        private System.Windows.Forms.RadioButton radio_GaussianFilter;
        private System.Windows.Forms.RadioButton radio_EmbossingFilter;
        private System.Windows.Forms.RadioButton radio_Canny;
        private System.Windows.Forms.RadioButton radio_Sobel;
        private System.Windows.Forms.CheckBox check_HoughLines;
        private System.Windows.Forms.RadioButton radio_NoEdge;
    }
}

