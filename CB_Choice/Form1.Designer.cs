﻿namespace CB_Choice
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
            this.cdList = new System.Windows.Forms.ComboBox();
            this.txtList = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cdList
            // 
            this.cdList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdList.FormattingEnabled = true;
            this.cdList.Location = new System.Drawing.Point(12, 12);
            this.cdList.Name = "cdList";
            this.cdList.Size = new System.Drawing.Size(217, 20);
            this.cdList.TabIndex = 0;
            this.cdList.SelectedIndexChanged += new System.EventHandler(this.CdList_SelectedIndexChanged);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(13, 39);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(216, 21);
            this.txtList.TabIndex = 1;
            this.txtList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtList_KeyPress);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(10, 63);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(69, 12);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "선택 결과 : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 193);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 217);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.cdList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "메뉴 선택 추가";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cdList;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAdd;
    }
}

