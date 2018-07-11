namespace sorting_algorithm
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
            this.lb_list = new System.Windows.Forms.Label();
            this.btn_random_list = new System.Windows.Forms.Button();
            this.btn_bubble_sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_list
            // 
            this.lb_list.AutoSize = true;
            this.lb_list.Location = new System.Drawing.Point(49, 65);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(0, 20);
            this.lb_list.TabIndex = 0;
            // 
            // btn_random_list
            // 
            this.btn_random_list.Location = new System.Drawing.Point(377, 44);
            this.btn_random_list.Name = "btn_random_list";
            this.btn_random_list.Size = new System.Drawing.Size(116, 62);
            this.btn_random_list.TabIndex = 1;
            this.btn_random_list.Text = "random list";
            this.btn_random_list.UseVisualStyleBackColor = true;
            this.btn_random_list.Click += new System.EventHandler(this.btn_random_list_Click);
            // 
            // btn_bubble_sort
            // 
            this.btn_bubble_sort.Location = new System.Drawing.Point(377, 161);
            this.btn_bubble_sort.Name = "btn_bubble_sort";
            this.btn_bubble_sort.Size = new System.Drawing.Size(116, 66);
            this.btn_bubble_sort.TabIndex = 2;
            this.btn_bubble_sort.Text = "bubble sort";
            this.btn_bubble_sort.UseVisualStyleBackColor = true;
            this.btn_bubble_sort.Click += new System.EventHandler(this.btn_bubble_sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 520);
            this.Controls.Add(this.btn_bubble_sort);
            this.Controls.Add(this.btn_random_list);
            this.Controls.Add(this.lb_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_list;
        private System.Windows.Forms.Button btn_random_list;
        private System.Windows.Forms.Button btn_bubble_sort;
    }
}

