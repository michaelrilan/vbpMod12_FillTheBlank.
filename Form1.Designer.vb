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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sentence_1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sentence_2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resultss = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a Sentence that contains three underscore""__"" and a word:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'sentence_1
        '
        Me.sentence_1.Location = New System.Drawing.Point(12, 55)
        Me.sentence_1.Name = "sentence_1"
        Me.sentence_1.Size = New System.Drawing.Size(246, 20)
        Me.sentence_1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter a second word to fill the blank:"
        '
        'sentence_2
        '
        Me.sentence_2.Location = New System.Drawing.Point(12, 128)
        Me.sentence_2.Name = "sentence_2"
        Me.sentence_2.Size = New System.Drawing.Size(246, 20)
        Me.sentence_2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'resultss
        '
        Me.resultss.AutoSize = True
        Me.resultss.Location = New System.Drawing.Point(12, 212)
        Me.resultss.Name = "resultss"
        Me.resultss.Size = New System.Drawing.Size(10, 13)
        Me.resultss.TabIndex = 6
        Me.resultss.Text = ":"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 256)
        Me.Controls.Add(Me.resultss)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sentence_2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sentence_1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "vbpMod12_FillTheBlank."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sentence_1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents sentence_2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents resultss As Label
End Class
