namespace Project_2___Object_Collisions
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
            this.grpBoxes = new System.Windows.Forms.GroupBox();
            this.lblBoxesCollided = new System.Windows.Forms.Label();
            this.lblBoxZ2 = new System.Windows.Forms.Label();
            this.lblBoxY2 = new System.Windows.Forms.Label();
            this.lblBoxX2 = new System.Windows.Forms.Label();
            this.txtMinZ2 = new System.Windows.Forms.TextBox();
            this.txtMinY2 = new System.Windows.Forms.TextBox();
            this.txtMinX2 = new System.Windows.Forms.TextBox();
            this.txtMaxZ2 = new System.Windows.Forms.TextBox();
            this.txtMaxY2 = new System.Windows.Forms.TextBox();
            this.txtMaxX2 = new System.Windows.Forms.TextBox();
            this.lblMax2 = new System.Windows.Forms.Label();
            this.lblMin2 = new System.Windows.Forms.Label();
            this.lblBox2 = new System.Windows.Forms.Label();
            this.lblBoxZ1 = new System.Windows.Forms.Label();
            this.lblBoxY1 = new System.Windows.Forms.Label();
            this.lblBoxX1 = new System.Windows.Forms.Label();
            this.txtMinZ1 = new System.Windows.Forms.TextBox();
            this.txtMinY1 = new System.Windows.Forms.TextBox();
            this.txtMinX1 = new System.Windows.Forms.TextBox();
            this.txtMaxZ1 = new System.Windows.Forms.TextBox();
            this.txtMaxY1 = new System.Windows.Forms.TextBox();
            this.txtMaxX1 = new System.Windows.Forms.TextBox();
            this.lblMax1 = new System.Windows.Forms.Label();
            this.lblMin1 = new System.Windows.Forms.Label();
            this.lblBox1 = new System.Windows.Forms.Label();
            this.grpSpheres = new System.Windows.Forms.GroupBox();
            this.lblSumOfRadii = new System.Windows.Forms.Label();
            this.lblSpheresCollided = new System.Windows.Forms.Label();
            this.lblRadius2 = new System.Windows.Forms.Label();
            this.lblRadius1 = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtVertexZ2 = new System.Windows.Forms.TextBox();
            this.txtVertexY2 = new System.Windows.Forms.TextBox();
            this.txtVertexX2 = new System.Windows.Forms.TextBox();
            this.txtCentreZ2 = new System.Windows.Forms.TextBox();
            this.txtCentreY2 = new System.Windows.Forms.TextBox();
            this.txtCentreX2 = new System.Windows.Forms.TextBox();
            this.lblVertex2 = new System.Windows.Forms.Label();
            this.lblCentre2 = new System.Windows.Forms.Label();
            this.lblZ2 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblObject2 = new System.Windows.Forms.Label();
            this.txtVertexZ1 = new System.Windows.Forms.TextBox();
            this.txtVertexY1 = new System.Windows.Forms.TextBox();
            this.txtVertexX1 = new System.Windows.Forms.TextBox();
            this.txtCentreZ1 = new System.Windows.Forms.TextBox();
            this.txtCentreY1 = new System.Windows.Forms.TextBox();
            this.txtCentreX1 = new System.Windows.Forms.TextBox();
            this.lblVertex1 = new System.Windows.Forms.Label();
            this.lblCentre1 = new System.Windows.Forms.Label();
            this.lblZ1 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblObject1 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpBoxes.SuspendLayout();
            this.grpSpheres.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxes
            // 
            this.grpBoxes.Controls.Add(this.lblBoxesCollided);
            this.grpBoxes.Controls.Add(this.lblBoxZ2);
            this.grpBoxes.Controls.Add(this.lblBoxY2);
            this.grpBoxes.Controls.Add(this.lblBoxX2);
            this.grpBoxes.Controls.Add(this.txtMinZ2);
            this.grpBoxes.Controls.Add(this.txtMinY2);
            this.grpBoxes.Controls.Add(this.txtMinX2);
            this.grpBoxes.Controls.Add(this.txtMaxZ2);
            this.grpBoxes.Controls.Add(this.txtMaxY2);
            this.grpBoxes.Controls.Add(this.txtMaxX2);
            this.grpBoxes.Controls.Add(this.lblMax2);
            this.grpBoxes.Controls.Add(this.lblMin2);
            this.grpBoxes.Controls.Add(this.lblBox2);
            this.grpBoxes.Controls.Add(this.lblBoxZ1);
            this.grpBoxes.Controls.Add(this.lblBoxY1);
            this.grpBoxes.Controls.Add(this.lblBoxX1);
            this.grpBoxes.Controls.Add(this.txtMinZ1);
            this.grpBoxes.Controls.Add(this.txtMinY1);
            this.grpBoxes.Controls.Add(this.txtMinX1);
            this.grpBoxes.Controls.Add(this.txtMaxZ1);
            this.grpBoxes.Controls.Add(this.txtMaxY1);
            this.grpBoxes.Controls.Add(this.txtMaxX1);
            this.grpBoxes.Controls.Add(this.lblMax1);
            this.grpBoxes.Controls.Add(this.lblMin1);
            this.grpBoxes.Controls.Add(this.lblBox1);
            this.grpBoxes.Location = new System.Drawing.Point(390, 274);
            this.grpBoxes.Name = "grpBoxes";
            this.grpBoxes.Size = new System.Drawing.Size(362, 169);
            this.grpBoxes.TabIndex = 90;
            this.grpBoxes.TabStop = false;
            this.grpBoxes.Text = "Bounding boxes";
            this.grpBoxes.Visible = false;
            // 
            // lblBoxesCollided
            // 
            this.lblBoxesCollided.AutoSize = true;
            this.lblBoxesCollided.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxesCollided.Location = new System.Drawing.Point(12, 142);
            this.lblBoxesCollided.Name = "lblBoxesCollided";
            this.lblBoxesCollided.Size = new System.Drawing.Size(59, 13);
            this.lblBoxesCollided.TabIndex = 32;
            this.lblBoxesCollided.Text = "Collided?";
            // 
            // lblBoxZ2
            // 
            this.lblBoxZ2.AutoSize = true;
            this.lblBoxZ2.Location = new System.Drawing.Point(191, 110);
            this.lblBoxZ2.Name = "lblBoxZ2";
            this.lblBoxZ2.Size = new System.Drawing.Size(44, 13);
            this.lblBoxZ2.TabIndex = 59;
            this.lblBoxZ2.Text = "Z-coord";
            // 
            // lblBoxY2
            // 
            this.lblBoxY2.AutoSize = true;
            this.lblBoxY2.Location = new System.Drawing.Point(191, 84);
            this.lblBoxY2.Name = "lblBoxY2";
            this.lblBoxY2.Size = new System.Drawing.Size(44, 13);
            this.lblBoxY2.TabIndex = 58;
            this.lblBoxY2.Text = "Y-coord";
            // 
            // lblBoxX2
            // 
            this.lblBoxX2.AutoSize = true;
            this.lblBoxX2.Location = new System.Drawing.Point(191, 58);
            this.lblBoxX2.Name = "lblBoxX2";
            this.lblBoxX2.Size = new System.Drawing.Size(44, 13);
            this.lblBoxX2.TabIndex = 57;
            this.lblBoxX2.Text = "X-coord";
            // 
            // txtMinZ2
            // 
            this.txtMinZ2.Enabled = false;
            this.txtMinZ2.Location = new System.Drawing.Point(241, 107);
            this.txtMinZ2.Name = "txtMinZ2";
            this.txtMinZ2.Size = new System.Drawing.Size(40, 20);
            this.txtMinZ2.TabIndex = 56;
            // 
            // txtMinY2
            // 
            this.txtMinY2.Enabled = false;
            this.txtMinY2.Location = new System.Drawing.Point(241, 81);
            this.txtMinY2.Name = "txtMinY2";
            this.txtMinY2.Size = new System.Drawing.Size(40, 20);
            this.txtMinY2.TabIndex = 55;
            // 
            // txtMinX2
            // 
            this.txtMinX2.Enabled = false;
            this.txtMinX2.Location = new System.Drawing.Point(241, 55);
            this.txtMinX2.Name = "txtMinX2";
            this.txtMinX2.Size = new System.Drawing.Size(40, 20);
            this.txtMinX2.TabIndex = 54;
            // 
            // txtMaxZ2
            // 
            this.txtMaxZ2.Enabled = false;
            this.txtMaxZ2.Location = new System.Drawing.Point(293, 107);
            this.txtMaxZ2.Name = "txtMaxZ2";
            this.txtMaxZ2.Size = new System.Drawing.Size(40, 20);
            this.txtMaxZ2.TabIndex = 53;
            // 
            // txtMaxY2
            // 
            this.txtMaxY2.Enabled = false;
            this.txtMaxY2.Location = new System.Drawing.Point(293, 81);
            this.txtMaxY2.Name = "txtMaxY2";
            this.txtMaxY2.Size = new System.Drawing.Size(40, 20);
            this.txtMaxY2.TabIndex = 52;
            // 
            // txtMaxX2
            // 
            this.txtMaxX2.Enabled = false;
            this.txtMaxX2.Location = new System.Drawing.Point(293, 55);
            this.txtMaxX2.Name = "txtMaxX2";
            this.txtMaxX2.Size = new System.Drawing.Size(40, 20);
            this.txtMaxX2.TabIndex = 51;
            // 
            // lblMax2
            // 
            this.lblMax2.AutoSize = true;
            this.lblMax2.Location = new System.Drawing.Point(290, 38);
            this.lblMax2.Name = "lblMax2";
            this.lblMax2.Size = new System.Drawing.Size(51, 13);
            this.lblMax2.TabIndex = 50;
            this.lblMax2.Text = "Maximum";
            // 
            // lblMin2
            // 
            this.lblMin2.AutoSize = true;
            this.lblMin2.Location = new System.Drawing.Point(236, 38);
            this.lblMin2.Name = "lblMin2";
            this.lblMin2.Size = new System.Drawing.Size(48, 13);
            this.lblMin2.TabIndex = 49;
            this.lblMin2.Text = "Minimum";
            // 
            // lblBox2
            // 
            this.lblBox2.AutoSize = true;
            this.lblBox2.Location = new System.Drawing.Point(267, 16);
            this.lblBox2.Name = "lblBox2";
            this.lblBox2.Size = new System.Drawing.Size(34, 13);
            this.lblBox2.TabIndex = 48;
            this.lblBox2.Text = "Box 2";
            // 
            // lblBoxZ1
            // 
            this.lblBoxZ1.AutoSize = true;
            this.lblBoxZ1.Location = new System.Drawing.Point(12, 110);
            this.lblBoxZ1.Name = "lblBoxZ1";
            this.lblBoxZ1.Size = new System.Drawing.Size(44, 13);
            this.lblBoxZ1.TabIndex = 47;
            this.lblBoxZ1.Text = "Z-coord";
            // 
            // lblBoxY1
            // 
            this.lblBoxY1.AutoSize = true;
            this.lblBoxY1.Location = new System.Drawing.Point(12, 84);
            this.lblBoxY1.Name = "lblBoxY1";
            this.lblBoxY1.Size = new System.Drawing.Size(44, 13);
            this.lblBoxY1.TabIndex = 46;
            this.lblBoxY1.Text = "Y-coord";
            // 
            // lblBoxX1
            // 
            this.lblBoxX1.AutoSize = true;
            this.lblBoxX1.Location = new System.Drawing.Point(12, 58);
            this.lblBoxX1.Name = "lblBoxX1";
            this.lblBoxX1.Size = new System.Drawing.Size(44, 13);
            this.lblBoxX1.TabIndex = 45;
            this.lblBoxX1.Text = "X-coord";
            // 
            // txtMinZ1
            // 
            this.txtMinZ1.Enabled = false;
            this.txtMinZ1.Location = new System.Drawing.Point(62, 107);
            this.txtMinZ1.Name = "txtMinZ1";
            this.txtMinZ1.Size = new System.Drawing.Size(40, 20);
            this.txtMinZ1.TabIndex = 44;
            // 
            // txtMinY1
            // 
            this.txtMinY1.Enabled = false;
            this.txtMinY1.Location = new System.Drawing.Point(62, 81);
            this.txtMinY1.Name = "txtMinY1";
            this.txtMinY1.Size = new System.Drawing.Size(40, 20);
            this.txtMinY1.TabIndex = 43;
            // 
            // txtMinX1
            // 
            this.txtMinX1.Enabled = false;
            this.txtMinX1.Location = new System.Drawing.Point(62, 55);
            this.txtMinX1.Name = "txtMinX1";
            this.txtMinX1.Size = new System.Drawing.Size(40, 20);
            this.txtMinX1.TabIndex = 42;
            // 
            // txtMaxZ1
            // 
            this.txtMaxZ1.Enabled = false;
            this.txtMaxZ1.Location = new System.Drawing.Point(114, 107);
            this.txtMaxZ1.Name = "txtMaxZ1";
            this.txtMaxZ1.Size = new System.Drawing.Size(40, 20);
            this.txtMaxZ1.TabIndex = 41;
            // 
            // txtMaxY1
            // 
            this.txtMaxY1.Enabled = false;
            this.txtMaxY1.Location = new System.Drawing.Point(114, 81);
            this.txtMaxY1.Name = "txtMaxY1";
            this.txtMaxY1.Size = new System.Drawing.Size(40, 20);
            this.txtMaxY1.TabIndex = 40;
            // 
            // txtMaxX1
            // 
            this.txtMaxX1.Enabled = false;
            this.txtMaxX1.Location = new System.Drawing.Point(114, 55);
            this.txtMaxX1.Name = "txtMaxX1";
            this.txtMaxX1.Size = new System.Drawing.Size(40, 20);
            this.txtMaxX1.TabIndex = 39;
            // 
            // lblMax1
            // 
            this.lblMax1.AutoSize = true;
            this.lblMax1.Location = new System.Drawing.Point(111, 38);
            this.lblMax1.Name = "lblMax1";
            this.lblMax1.Size = new System.Drawing.Size(51, 13);
            this.lblMax1.TabIndex = 35;
            this.lblMax1.Text = "Maximum";
            // 
            // lblMin1
            // 
            this.lblMin1.AutoSize = true;
            this.lblMin1.Location = new System.Drawing.Point(57, 38);
            this.lblMin1.Name = "lblMin1";
            this.lblMin1.Size = new System.Drawing.Size(48, 13);
            this.lblMin1.TabIndex = 34;
            this.lblMin1.Text = "Minimum";
            // 
            // lblBox1
            // 
            this.lblBox1.AutoSize = true;
            this.lblBox1.Location = new System.Drawing.Point(88, 16);
            this.lblBox1.Name = "lblBox1";
            this.lblBox1.Size = new System.Drawing.Size(34, 13);
            this.lblBox1.TabIndex = 33;
            this.lblBox1.Text = "Box 1";
            // 
            // grpSpheres
            // 
            this.grpSpheres.Controls.Add(this.lblSumOfRadii);
            this.grpSpheres.Controls.Add(this.lblSpheresCollided);
            this.grpSpheres.Controls.Add(this.lblRadius2);
            this.grpSpheres.Controls.Add(this.lblRadius1);
            this.grpSpheres.Controls.Add(this.lblDistance);
            this.grpSpheres.Location = new System.Drawing.Point(41, 274);
            this.grpSpheres.Name = "grpSpheres";
            this.grpSpheres.Size = new System.Drawing.Size(301, 169);
            this.grpSpheres.TabIndex = 89;
            this.grpSpheres.TabStop = false;
            this.grpSpheres.Text = "Bounding spheres";
            this.grpSpheres.Visible = false;
            // 
            // lblSumOfRadii
            // 
            this.lblSumOfRadii.AutoSize = true;
            this.lblSumOfRadii.Location = new System.Drawing.Point(28, 78);
            this.lblSumOfRadii.Name = "lblSumOfRadii";
            this.lblSumOfRadii.Size = new System.Drawing.Size(62, 13);
            this.lblSumOfRadii.TabIndex = 32;
            this.lblSumOfRadii.Text = "Sum of radii";
            // 
            // lblSpheresCollided
            // 
            this.lblSpheresCollided.AutoSize = true;
            this.lblSpheresCollided.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpheresCollided.Location = new System.Drawing.Point(29, 142);
            this.lblSpheresCollided.Name = "lblSpheresCollided";
            this.lblSpheresCollided.Size = new System.Drawing.Size(59, 13);
            this.lblSpheresCollided.TabIndex = 31;
            this.lblSpheresCollided.Text = "Collided?";
            // 
            // lblRadius2
            // 
            this.lblRadius2.AutoSize = true;
            this.lblRadius2.Location = new System.Drawing.Point(28, 55);
            this.lblRadius2.Name = "lblRadius2";
            this.lblRadius2.Size = new System.Drawing.Size(49, 13);
            this.lblRadius2.TabIndex = 30;
            this.lblRadius2.Text = "Radius 2";
            // 
            // lblRadius1
            // 
            this.lblRadius1.AutoSize = true;
            this.lblRadius1.Location = new System.Drawing.Point(28, 32);
            this.lblRadius1.Name = "lblRadius1";
            this.lblRadius1.Size = new System.Drawing.Size(49, 13);
            this.lblRadius1.TabIndex = 29;
            this.lblRadius1.Text = "Radius 1";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(29, 107);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(131, 13);
            this.lblDistance.TabIndex = 28;
            this.lblDistance.Text = "Distance between centres";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(63, 242);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(64, 13);
            this.lblResults.TabIndex = 88;
            this.lblResults.Text = "RESULTS";
            this.lblResults.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(432, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 25);
            this.btnClear.TabIndex = 87;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(184, 197);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(128, 25);
            this.btnCheck.TabIndex = 86;
            this.btnCheck.Text = "Collision Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtVertexZ2
            // 
            this.txtVertexZ2.Location = new System.Drawing.Point(573, 151);
            this.txtVertexZ2.Name = "txtVertexZ2";
            this.txtVertexZ2.Size = new System.Drawing.Size(40, 20);
            this.txtVertexZ2.TabIndex = 85;
            // 
            // txtVertexY2
            // 
            this.txtVertexY2.Location = new System.Drawing.Point(507, 151);
            this.txtVertexY2.Name = "txtVertexY2";
            this.txtVertexY2.Size = new System.Drawing.Size(40, 20);
            this.txtVertexY2.TabIndex = 84;
            // 
            // txtVertexX2
            // 
            this.txtVertexX2.Location = new System.Drawing.Point(442, 151);
            this.txtVertexX2.Name = "txtVertexX2";
            this.txtVertexX2.Size = new System.Drawing.Size(40, 20);
            this.txtVertexX2.TabIndex = 83;
            // 
            // txtCentreZ2
            // 
            this.txtCentreZ2.Location = new System.Drawing.Point(573, 125);
            this.txtCentreZ2.Name = "txtCentreZ2";
            this.txtCentreZ2.Size = new System.Drawing.Size(40, 20);
            this.txtCentreZ2.TabIndex = 82;
            // 
            // txtCentreY2
            // 
            this.txtCentreY2.Location = new System.Drawing.Point(507, 125);
            this.txtCentreY2.Name = "txtCentreY2";
            this.txtCentreY2.Size = new System.Drawing.Size(40, 20);
            this.txtCentreY2.TabIndex = 81;
            // 
            // txtCentreX2
            // 
            this.txtCentreX2.Location = new System.Drawing.Point(442, 125);
            this.txtCentreX2.Name = "txtCentreX2";
            this.txtCentreX2.Size = new System.Drawing.Size(40, 20);
            this.txtCentreX2.TabIndex = 80;
            // 
            // lblVertex2
            // 
            this.lblVertex2.AutoSize = true;
            this.lblVertex2.Location = new System.Drawing.Point(348, 154);
            this.lblVertex2.Name = "lblVertex2";
            this.lblVertex2.Size = new System.Drawing.Size(80, 13);
            this.lblVertex2.TabIndex = 79;
            this.lblVertex2.Text = "Furthest vertex:";
            // 
            // lblCentre2
            // 
            this.lblCentre2.AutoSize = true;
            this.lblCentre2.Location = new System.Drawing.Point(387, 128);
            this.lblCentre2.Name = "lblCentre2";
            this.lblCentre2.Size = new System.Drawing.Size(41, 13);
            this.lblCentre2.TabIndex = 78;
            this.lblCentre2.Text = "Centre:";
            // 
            // lblZ2
            // 
            this.lblZ2.AutoSize = true;
            this.lblZ2.Location = new System.Drawing.Point(569, 102);
            this.lblZ2.Name = "lblZ2";
            this.lblZ2.Size = new System.Drawing.Size(44, 13);
            this.lblZ2.TabIndex = 77;
            this.lblZ2.Text = "Z-coord";
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(503, 102);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(44, 13);
            this.lblY2.TabIndex = 76;
            this.lblY2.Text = "Y-coord";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(438, 102);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(44, 13);
            this.lblX2.TabIndex = 75;
            this.lblX2.Text = "X-coord";
            // 
            // lblObject2
            // 
            this.lblObject2.AutoSize = true;
            this.lblObject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObject2.Location = new System.Drawing.Point(491, 75);
            this.lblObject2.Name = "lblObject2";
            this.lblObject2.Size = new System.Drawing.Size(55, 13);
            this.lblObject2.TabIndex = 74;
            this.lblObject2.Text = "Object 2";
            // 
            // txtVertexZ1
            // 
            this.txtVertexZ1.Location = new System.Drawing.Point(263, 149);
            this.txtVertexZ1.Name = "txtVertexZ1";
            this.txtVertexZ1.Size = new System.Drawing.Size(40, 20);
            this.txtVertexZ1.TabIndex = 73;
            // 
            // txtVertexY1
            // 
            this.txtVertexY1.Location = new System.Drawing.Point(197, 149);
            this.txtVertexY1.Name = "txtVertexY1";
            this.txtVertexY1.Size = new System.Drawing.Size(40, 20);
            this.txtVertexY1.TabIndex = 72;
            // 
            // txtVertexX1
            // 
            this.txtVertexX1.Location = new System.Drawing.Point(132, 149);
            this.txtVertexX1.Name = "txtVertexX1";
            this.txtVertexX1.Size = new System.Drawing.Size(40, 20);
            this.txtVertexX1.TabIndex = 71;
            // 
            // txtCentreZ1
            // 
            this.txtCentreZ1.Location = new System.Drawing.Point(263, 123);
            this.txtCentreZ1.Name = "txtCentreZ1";
            this.txtCentreZ1.Size = new System.Drawing.Size(40, 20);
            this.txtCentreZ1.TabIndex = 70;
            // 
            // txtCentreY1
            // 
            this.txtCentreY1.Location = new System.Drawing.Point(197, 123);
            this.txtCentreY1.Name = "txtCentreY1";
            this.txtCentreY1.Size = new System.Drawing.Size(40, 20);
            this.txtCentreY1.TabIndex = 69;
            // 
            // txtCentreX1
            // 
            this.txtCentreX1.Location = new System.Drawing.Point(132, 123);
            this.txtCentreX1.Name = "txtCentreX1";
            this.txtCentreX1.Size = new System.Drawing.Size(40, 20);
            this.txtCentreX1.TabIndex = 68;
            // 
            // lblVertex1
            // 
            this.lblVertex1.AutoSize = true;
            this.lblVertex1.Location = new System.Drawing.Point(38, 152);
            this.lblVertex1.Name = "lblVertex1";
            this.lblVertex1.Size = new System.Drawing.Size(80, 13);
            this.lblVertex1.TabIndex = 67;
            this.lblVertex1.Text = "Furthest vertex:";
            // 
            // lblCentre1
            // 
            this.lblCentre1.AutoSize = true;
            this.lblCentre1.Location = new System.Drawing.Point(77, 126);
            this.lblCentre1.Name = "lblCentre1";
            this.lblCentre1.Size = new System.Drawing.Size(41, 13);
            this.lblCentre1.TabIndex = 66;
            this.lblCentre1.Text = "Centre:";
            // 
            // lblZ1
            // 
            this.lblZ1.AutoSize = true;
            this.lblZ1.Location = new System.Drawing.Point(259, 100);
            this.lblZ1.Name = "lblZ1";
            this.lblZ1.Size = new System.Drawing.Size(44, 13);
            this.lblZ1.TabIndex = 65;
            this.lblZ1.Text = "Z-coord";
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(193, 100);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(44, 13);
            this.lblY1.TabIndex = 64;
            this.lblY1.Text = "Y-coord";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(128, 100);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(44, 13);
            this.lblX1.TabIndex = 63;
            this.lblX1.Text = "X-coord";
            // 
            // lblObject1
            // 
            this.lblObject1.AutoSize = true;
            this.lblObject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObject1.Location = new System.Drawing.Point(181, 73);
            this.lblObject1.Name = "lblObject1";
            this.lblObject1.Size = new System.Drawing.Size(55, 13);
            this.lblObject1.TabIndex = 62;
            this.lblObject1.Text = "Object 1";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(190, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(354, 39);
            this.lblHeading.TabIndex = 61;
            this.lblHeading.Text = "To determine if two objects have potentially collided by checking to see if:\r\n   " +
    "  (a) their bounding spheres have intersected and \r\n     (b) their bounding boxe" +
    "s have intersected.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 449);
            this.Controls.Add(this.grpBoxes);
            this.Controls.Add(this.grpSpheres);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtVertexZ2);
            this.Controls.Add(this.txtVertexY2);
            this.Controls.Add(this.txtVertexX2);
            this.Controls.Add(this.txtCentreZ2);
            this.Controls.Add(this.txtCentreY2);
            this.Controls.Add(this.txtCentreX2);
            this.Controls.Add(this.lblVertex2);
            this.Controls.Add(this.lblCentre2);
            this.Controls.Add(this.lblZ2);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblObject2);
            this.Controls.Add(this.txtVertexZ1);
            this.Controls.Add(this.txtVertexY1);
            this.Controls.Add(this.txtVertexX1);
            this.Controls.Add(this.txtCentreZ1);
            this.Controls.Add(this.txtCentreY1);
            this.Controls.Add(this.txtCentreX1);
            this.Controls.Add(this.lblVertex1);
            this.Controls.Add(this.lblCentre1);
            this.Controls.Add(this.lblZ1);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.lblObject1);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxes.ResumeLayout(false);
            this.grpBoxes.PerformLayout();
            this.grpSpheres.ResumeLayout(false);
            this.grpSpheres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxes;
        private System.Windows.Forms.Label lblBoxesCollided;
        private System.Windows.Forms.Label lblBoxZ2;
        private System.Windows.Forms.Label lblBoxY2;
        private System.Windows.Forms.Label lblBoxX2;
        private System.Windows.Forms.TextBox txtMinZ2;
        private System.Windows.Forms.TextBox txtMinY2;
        private System.Windows.Forms.TextBox txtMinX2;
        private System.Windows.Forms.TextBox txtMaxZ2;
        private System.Windows.Forms.TextBox txtMaxY2;
        private System.Windows.Forms.TextBox txtMaxX2;
        private System.Windows.Forms.Label lblMax2;
        private System.Windows.Forms.Label lblMin2;
        private System.Windows.Forms.Label lblBox2;
        private System.Windows.Forms.Label lblBoxZ1;
        private System.Windows.Forms.Label lblBoxY1;
        private System.Windows.Forms.Label lblBoxX1;
        private System.Windows.Forms.TextBox txtMinZ1;
        private System.Windows.Forms.TextBox txtMinY1;
        private System.Windows.Forms.TextBox txtMinX1;
        private System.Windows.Forms.TextBox txtMaxZ1;
        private System.Windows.Forms.TextBox txtMaxY1;
        private System.Windows.Forms.TextBox txtMaxX1;
        private System.Windows.Forms.Label lblMax1;
        private System.Windows.Forms.Label lblMin1;
        private System.Windows.Forms.Label lblBox1;
        private System.Windows.Forms.GroupBox grpSpheres;
        private System.Windows.Forms.Label lblSumOfRadii;
        private System.Windows.Forms.Label lblSpheresCollided;
        private System.Windows.Forms.Label lblRadius2;
        private System.Windows.Forms.Label lblRadius1;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtVertexZ2;
        private System.Windows.Forms.TextBox txtVertexY2;
        private System.Windows.Forms.TextBox txtVertexX2;
        private System.Windows.Forms.TextBox txtCentreZ2;
        private System.Windows.Forms.TextBox txtCentreY2;
        private System.Windows.Forms.TextBox txtCentreX2;
        private System.Windows.Forms.Label lblVertex2;
        private System.Windows.Forms.Label lblCentre2;
        private System.Windows.Forms.Label lblZ2;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblObject2;
        private System.Windows.Forms.TextBox txtVertexZ1;
        private System.Windows.Forms.TextBox txtVertexY1;
        private System.Windows.Forms.TextBox txtVertexX1;
        private System.Windows.Forms.TextBox txtCentreZ1;
        private System.Windows.Forms.TextBox txtCentreY1;
        private System.Windows.Forms.TextBox txtCentreX1;
        private System.Windows.Forms.Label lblVertex1;
        private System.Windows.Forms.Label lblCentre1;
        private System.Windows.Forms.Label lblZ1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblObject1;
        private System.Windows.Forms.Label lblHeading;
    }
}

