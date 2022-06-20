
namespace simulation_reseau_elec
{
    partial class View_graphe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.tbLatestValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAutoAxis = new System.Windows.Forms.CheckBox();
            this.tbLastValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.tbJour_nuit = new System.Windows.Forms.TextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.rtbErrors = new System.Windows.Forms.RichTextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.cbEolien = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(20, 55);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1227, 431);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // tbLatestValue
            // 
            this.tbLatestValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLatestValue.Location = new System.Drawing.Point(96, 16);
            this.tbLatestValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbLatestValue.Name = "tbLatestValue";
            this.tbLatestValue.ReadOnly = true;
            this.tbLatestValue.Size = new System.Drawing.Size(80, 27);
            this.tbLatestValue.TabIndex = 5;
            this.tbLatestValue.Text = "123";
            this.tbLatestValue.TextChanged += new System.EventHandler(this.tbLatestValue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesure N°:";
            // 
            // cbAutoAxis
            // 
            this.cbAutoAxis.AutoSize = true;
            this.cbAutoAxis.Checked = true;
            this.cbAutoAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoAxis.Location = new System.Drawing.Point(443, 20);
            this.cbAutoAxis.Margin = new System.Windows.Forms.Padding(4);
            this.cbAutoAxis.Name = "cbAutoAxis";
            this.cbAutoAxis.Size = new System.Drawing.Size(190, 21);
            this.cbAutoAxis.TabIndex = 14;
            this.cbAutoAxis.Text = "auto-axis on each update";
            this.cbAutoAxis.UseVisualStyleBackColor = true;
            this.cbAutoAxis.CheckedChanged += new System.EventHandler(this.cbAutoAxis_CheckedChanged);
            // 
            // tbLastValue
            // 
            this.tbLastValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastValue.Location = new System.Drawing.Point(299, 17);
            this.tbLastValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastValue.Name = "tbLastValue";
            this.tbLastValue.ReadOnly = true;
            this.tbLastValue.Size = new System.Drawing.Size(97, 27);
            this.tbLastValue.TabIndex = 13;
            this.tbLastValue.Text = "+123.4";
            this.tbLastValue.TextChanged += new System.EventHandler(this.tbLastValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Consommation :";
            // 
            // dataTimer
            // 
            this.dataTimer.Enabled = true;
            this.dataTimer.Interval = 500;
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 500;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Jour-Nuit:";
            // 
            // tbJour_nuit
            // 
            this.tbJour_nuit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJour_nuit.Location = new System.Drawing.Point(751, 17);
            this.tbJour_nuit.Margin = new System.Windows.Forms.Padding(4);
            this.tbJour_nuit.Name = "tbJour_nuit";
            this.tbJour_nuit.ReadOnly = true;
            this.tbJour_nuit.Size = new System.Drawing.Size(80, 27);
            this.tbJour_nuit.TabIndex = 24;
            this.tbJour_nuit.Text = "0";
            this.tbJour_nuit.TextChanged += new System.EventHandler(this.tbJour_nuit_TextChanged);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.Location = new System.Drawing.Point(1255, 55);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(469, 383);
            this.rtbMessage.TabIndex = 39;
            this.rtbMessage.Text = "";
            this.rtbMessage.TextChanged += new System.EventHandler(this.rtbMessage_TextChanged);
            // 
            // rtbErrors
            // 
            this.rtbErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbErrors.Location = new System.Drawing.Point(1255, 444);
            this.rtbErrors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbErrors.Name = "rtbErrors";
            this.rtbErrors.Size = new System.Drawing.Size(469, 262);
            this.rtbErrors.TabIndex = 46;
            this.rtbErrors.Text = "";
            this.rtbErrors.TextChanged += new System.EventHandler(this.rtbErrors_TextChanged);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(37, 544);
            this.bSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(139, 39);
            this.bSave.TabIndex = 47;
            this.bSave.Text = "Save graphe";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // cbEolien
            // 
            this.cbEolien.AutoSize = true;
            this.cbEolien.Checked = true;
            this.cbEolien.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEolien.Location = new System.Drawing.Point(855, 20);
            this.cbEolien.Name = "cbEolien";
            this.cbEolien.Size = new System.Drawing.Size(69, 21);
            this.cbEolien.TabIndex = 48;
            this.cbEolien.Text = "Eolien";
            this.cbEolien.UseVisualStyleBackColor = true;
            this.cbEolien.CheckedChanged += new System.EventHandler(this.cbEolien_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(947, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Vent:";
            // 
            // tbVent
            // 
            this.tbVent.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVent.Location = new System.Drawing.Point(1025, 17);
            this.tbVent.Margin = new System.Windows.Forms.Padding(4);
            this.tbVent.Name = "tbVent";
            this.tbVent.ReadOnly = true;
            this.tbVent.Size = new System.Drawing.Size(80, 27);
            this.tbVent.TabIndex = 49;
            this.tbVent.Text = "0";
            this.tbVent.TextChanged += new System.EventHandler(this.tbVent_TextChanged);
            // 
            // View_graphe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVent);
            this.Controls.Add(this.cbEolien);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.rtbErrors);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbJour_nuit);
            this.Controls.Add(this.cbAutoAxis);
            this.Controls.Add(this.tbLastValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLatestValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formsPlot1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_graphe";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.TextBox tbLatestValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAutoAxis;
        private System.Windows.Forms.TextBox tbLastValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJour_nuit;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.RichTextBox rtbErrors;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.CheckBox cbEolien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVent;
    }
}

