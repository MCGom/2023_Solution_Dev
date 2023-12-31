﻿namespace A_TextView
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
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnErase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEdit
            // 
            this.txtEdit.BackColor = System.Drawing.Color.White;
            this.txtEdit.Font = new System.Drawing.Font("바탕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEdit.ForeColor = System.Drawing.Color.Black;
            this.txtEdit.Location = new System.Drawing.Point(200, 25);
            this.txtEdit.Multiline = true;
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(400, 40);
            this.txtEdit.TabIndex = 0;
            this.txtEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdit_Typed);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEdit.ForeColor = System.Drawing.Color.Azure;
            this.btnEdit.Location = new System.Drawing.Point(210, 80);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 60);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "입력";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("함초롬바탕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblResult.Location = new System.Drawing.Point(200, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(71, 27);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "결과 : ";
            // 
            // btnErase
            // 
            this.btnErase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnErase.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnErase.FlatAppearance.BorderSize = 0;
            this.btnErase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnErase.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnErase.ForeColor = System.Drawing.Color.Azure;
            this.btnErase.Location = new System.Drawing.Point(430, 80);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(160, 60);
            this.btnErase.TabIndex = 3;
            this.btnErase.Text = "지우기";
            this.btnErase.UseVisualStyleBackColor = false;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(784, 393);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "문자 입출력";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnErase;
    }
}

