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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.BtnDivisionWithRemainder = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDivisionNoRemainder = New System.Windows.Forms.Button()
        Me.btnModulous = New System.Windows.Forms.Button()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnSquareRoot = New System.Windows.Forms.Button()
        Me.btnCeiling = New System.Windows.Forms.Button()
        Me.btnFloor = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNum1.Location = New System.Drawing.Point(33, 59)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(140, 31)
        Me.lblNum1.TabIndex = 3
        Me.lblNum1.Text = "Number 1:"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNum2.Location = New System.Drawing.Point(33, 118)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(140, 31)
        Me.lblNum2.TabIndex = 4
        Me.lblNum2.Text = "Number 2:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblResult.Location = New System.Drawing.Point(71, 429)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 31)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Result:"
        '
        'btnAddition
        '
        Me.btnAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddition.Location = New System.Drawing.Point(39, 182)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(65, 60)
        Me.btnAddition.TabIndex = 2
        Me.btnAddition.Text = "+"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'btnSubtraction
        '
        Me.btnSubtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtraction.Location = New System.Drawing.Point(129, 182)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(65, 60)
        Me.btnSubtraction.TabIndex = 3
        Me.btnSubtraction.Text = "-"
        Me.btnSubtraction.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplication.Location = New System.Drawing.Point(221, 182)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(65, 60)
        Me.btnMultiplication.TabIndex = 4
        Me.btnMultiplication.Text = "*"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'BtnDivisionWithRemainder
        '
        Me.BtnDivisionWithRemainder.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDivisionWithRemainder.Location = New System.Drawing.Point(312, 182)
        Me.BtnDivisionWithRemainder.Name = "BtnDivisionWithRemainder"
        Me.BtnDivisionWithRemainder.Size = New System.Drawing.Size(65, 60)
        Me.BtnDivisionWithRemainder.TabIndex = 5
        Me.BtnDivisionWithRemainder.Text = "÷"
        Me.BtnDivisionWithRemainder.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Coral
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(312, 335)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 60)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDivisionNoRemainder
        '
        Me.btnDivisionNoRemainder.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivisionNoRemainder.Location = New System.Drawing.Point(41, 257)
        Me.btnDivisionNoRemainder.Name = "btnDivisionNoRemainder"
        Me.btnDivisionNoRemainder.Size = New System.Drawing.Size(65, 60)
        Me.btnDivisionNoRemainder.TabIndex = 6
        Me.btnDivisionNoRemainder.Text = "\"
        Me.btnDivisionNoRemainder.UseVisualStyleBackColor = True
        '
        'btnModulous
        '
        Me.btnModulous.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModulous.Location = New System.Drawing.Point(130, 257)
        Me.btnModulous.Name = "btnModulous"
        Me.btnModulous.Size = New System.Drawing.Size(65, 60)
        Me.btnModulous.TabIndex = 7
        Me.btnModulous.Text = "%"
        Me.btnModulous.UseVisualStyleBackColor = True
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(186, 55)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(191, 40)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(186, 114)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(191, 40)
        Me.txtNum2.TabIndex = 1
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(177, 425)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(191, 40)
        Me.txtResult.TabIndex = 11
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkRed
        Me.btnExit.Location = New System.Drawing.Point(370, -2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 34)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "🔴"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPower.Location = New System.Drawing.Point(221, 257)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(65, 60)
        Me.btnPower.TabIndex = 12
        Me.btnPower.Text = "^"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnSquareRoot
        '
        Me.btnSquareRoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquareRoot.Location = New System.Drawing.Point(312, 257)
        Me.btnSquareRoot.Name = "btnSquareRoot"
        Me.btnSquareRoot.Size = New System.Drawing.Size(65, 60)
        Me.btnSquareRoot.TabIndex = 13
        Me.btnSquareRoot.Text = "√"
        Me.btnSquareRoot.UseVisualStyleBackColor = True
        '
        'btnCeiling
        '
        Me.btnCeiling.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCeiling.Location = New System.Drawing.Point(41, 333)
        Me.btnCeiling.Name = "btnCeiling"
        Me.btnCeiling.Size = New System.Drawing.Size(65, 60)
        Me.btnCeiling.TabIndex = 14
        Me.btnCeiling.Text = "Ru"
        Me.btnCeiling.UseVisualStyleBackColor = True
        '
        'btnFloor
        '
        Me.btnFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFloor.Location = New System.Drawing.Point(130, 335)
        Me.btnFloor.Name = "btnFloor"
        Me.btnFloor.Size = New System.Drawing.Size(65, 60)
        Me.btnFloor.TabIndex = 15
        Me.btnFloor.Text = "Rd"
        Me.btnFloor.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMax.Location = New System.Drawing.Point(221, 335)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(65, 60)
        Me.btnMax.TabIndex = 16
        Me.btnMax.Text = "Mx"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(409, 500)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnFloor)
        Me.Controls.Add(Me.btnCeiling)
        Me.Controls.Add(Me.btnSquareRoot)
        Me.Controls.Add(Me.btnPower)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.btnModulous)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDivisionNoRemainder)
        Me.Controls.Add(Me.BtnDivisionWithRemainder)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnAddition As Button
    Friend WithEvents btnSubtraction As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents BtnDivisionWithRemainder As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDivisionNoRemainder As Button
    Friend WithEvents btnModulous As Button
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnSquareRoot As Button
    Friend WithEvents btnCeiling As Button
    Friend WithEvents btnFloor As Button
    Friend WithEvents btnMax As Button
End Class
