<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnMars = New System.Windows.Forms.Button()
        Me.btnWinnipeg = New System.Windows.Forms.Button()
        Me.btnBanff = New System.Windows.Forms.Button()
        Me.btnEdmonton = New System.Windows.Forms.Button()
        Me.btnCalgary = New System.Windows.Forms.Button()
        Me.lblMyTrip = New System.Windows.Forms.Label()
        Me.picPlaces = New System.Windows.Forms.PictureBox()
        CType(Me.picPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(525, 299)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(112, 13)
        Me.lblDescription.TabIndex = 14
        Me.lblDescription.Text = "Description of Photo..."
        '
        'btnMars
        '
        Me.btnMars.Location = New System.Drawing.Point(955, 354)
        Me.btnMars.Name = "btnMars"
        Me.btnMars.Size = New System.Drawing.Size(75, 23)
        Me.btnMars.TabIndex = 13
        Me.btnMars.Text = "Mars"
        Me.btnMars.UseVisualStyleBackColor = True
        '
        'btnWinnipeg
        '
        Me.btnWinnipeg.Location = New System.Drawing.Point(749, 354)
        Me.btnWinnipeg.Name = "btnWinnipeg"
        Me.btnWinnipeg.Size = New System.Drawing.Size(75, 23)
        Me.btnWinnipeg.TabIndex = 12
        Me.btnWinnipeg.Text = "Winnipeg"
        Me.btnWinnipeg.UseVisualStyleBackColor = True
        '
        'btnBanff
        '
        Me.btnBanff.Location = New System.Drawing.Point(543, 354)
        Me.btnBanff.Name = "btnBanff"
        Me.btnBanff.Size = New System.Drawing.Size(75, 23)
        Me.btnBanff.TabIndex = 11
        Me.btnBanff.Text = "Banff"
        Me.btnBanff.UseVisualStyleBackColor = True
        '
        'btnEdmonton
        '
        Me.btnEdmonton.Location = New System.Drawing.Point(337, 354)
        Me.btnEdmonton.Name = "btnEdmonton"
        Me.btnEdmonton.Size = New System.Drawing.Size(75, 23)
        Me.btnEdmonton.TabIndex = 10
        Me.btnEdmonton.Text = "Edmonton"
        Me.btnEdmonton.UseVisualStyleBackColor = True
        '
        'btnCalgary
        '
        Me.btnCalgary.Location = New System.Drawing.Point(131, 354)
        Me.btnCalgary.Name = "btnCalgary"
        Me.btnCalgary.Size = New System.Drawing.Size(75, 23)
        Me.btnCalgary.TabIndex = 9
        Me.btnCalgary.Text = "Calgary"
        Me.btnCalgary.UseVisualStyleBackColor = True
        '
        'lblMyTrip
        '
        Me.lblMyTrip.AutoSize = True
        Me.lblMyTrip.Location = New System.Drawing.Point(551, 75)
        Me.lblMyTrip.Name = "lblMyTrip"
        Me.lblMyTrip.Size = New System.Drawing.Size(67, 13)
        Me.lblMyTrip.TabIndex = 8
        Me.lblMyTrip.Text = "My Trip To..."
        '
        'picPlaces
        '
        Me.picPlaces.Location = New System.Drawing.Point(427, 110)
        Me.picPlaces.Name = "picPlaces"
        Me.picPlaces.Size = New System.Drawing.Size(321, 160)
        Me.picPlaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlaces.TabIndex = 15
        Me.picPlaces.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 450)
        Me.Controls.Add(Me.picPlaces)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnMars)
        Me.Controls.Add(Me.btnWinnipeg)
        Me.Controls.Add(Me.btnBanff)
        Me.Controls.Add(Me.btnEdmonton)
        Me.Controls.Add(Me.btnCalgary)
        Me.Controls.Add(Me.lblMyTrip)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlaces As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents btnMars As System.Windows.Forms.Button
    Friend WithEvents btnWinnipeg As System.Windows.Forms.Button
    Friend WithEvents btnBanff As System.Windows.Forms.Button
    Friend WithEvents btnEdmonton As System.Windows.Forms.Button
    Friend WithEvents btnCalgary As System.Windows.Forms.Button
    Friend WithEvents lblMyTrip As System.Windows.Forms.Label

End Class
