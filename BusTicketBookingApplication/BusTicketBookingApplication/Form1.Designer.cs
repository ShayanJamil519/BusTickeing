
namespace BusTicketBookingApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNoOfMembers = new System.Windows.Forms.TextBox();
            this.buttonMembersAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus Tickets Booking Application";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of family members traveling:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNoOfMembers
            // 
            this.textBoxNoOfMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoOfMembers.Location = new System.Drawing.Point(490, 79);
            this.textBoxNoOfMembers.Multiline = true;
            this.textBoxNoOfMembers.Name = "textBoxNoOfMembers";
            this.textBoxNoOfMembers.Size = new System.Drawing.Size(199, 32);
            this.textBoxNoOfMembers.TabIndex = 2;
            this.textBoxNoOfMembers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonMembersAge
            // 
            this.buttonMembersAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMembersAge.Location = new System.Drawing.Point(248, 128);
            this.buttonMembersAge.Name = "buttonMembersAge";
            this.buttonMembersAge.Size = new System.Drawing.Size(280, 33);
            this.buttonMembersAge.TabIndex = 3;
            this.buttonMembersAge.Text = "Number of Members and their Age:";
            this.buttonMembersAge.UseVisualStyleBackColor = true;
            this.buttonMembersAge.Click += new System.EventHandler(this.buttonMembersAge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.buttonMembersAge);
            this.Controls.Add(this.textBoxNoOfMembers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNoOfMembers;
        private System.Windows.Forms.Button buttonMembersAge;
    }
}

