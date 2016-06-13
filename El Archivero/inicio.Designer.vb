<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RadialMenu1 = New DevExpress.XtraBars.Ribbon.RadialMenu(Me.components)
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        CType(Me.RadialMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadialMenu1
        '
        Me.RadialMenu1.Name = "RadialMenu1"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.Name = "SqlDataSource1"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(42, 53)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 97)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadialMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents RadialMenu1 As DevExpress.XtraBars.Ribbon.RadialMenu
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents ListView1 As ListView
End Class
