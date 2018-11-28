Module PropiedadesPersonalización

    Public ColorPrincipal As Color = Color.FromArgb(235, 249, 248)
    Public ColorLetras As Color = Color.FromArgb(19, 34, 57)
    Public ColorSecundario As Color = Color.FromArgb(151, 204, 210)
    Public ColorLetrasSecundario As Color = Color.Black
    'Public ColorSecundario As Color = Color.FromArgb(0, 0, 0)

    Public FuenteTextos As Font = New Font("Raleway", 13, FontStyle.Regular)

    ''' <summary>
    ''' Esta función ajusta el color de todos los formularios
    ''' </summary>
    Public Sub AjustarPropiedadesVisualesFormulario(ByRef FormularioParaCambiar As Form)
        'Esta instrucción ajusta el color de fondo del formulario principal
        FormularioParaCambiar.BackColor = ColorPrincipal
        AjustarTextosFormulario(FormularioParaCambiar)
        AjustarTextBoxsFormulario(FormularioParaCambiar)

    End Sub


    Private Sub AjustarTextosFormulario(ByRef FormularioParaCambiar As Form)
        'Este bucle ajusta los textos de todos los label del formulario principal

        For i As Integer = 0 To FormularioParaCambiar.Controls.Count - 1 Step 1
            If TypeOf FormularioParaCambiar.Controls(i) Is TableLayoutPanel Then
                For j As Integer = 0 To FormularioParaCambiar.Controls(i).Controls.Count - 1 Step 1
                    If TypeOf FormularioParaCambiar.Controls(i).Controls(j) Is Label Then
                        With FormularioParaCambiar.Controls(i).Controls(j)
                            .Font = FuenteTextos
                            .ForeColor = ColorLetras
                            .Dock = DockStyle.Fill
                        End With
                    End If
                Next
            End If
        Next

    End Sub

    Private Sub AjustarTextBoxsFormulario(ByRef FormularioParaCambiar As Form)
        'Este bucle ajusta los textos de todos los label del formulario principal

        For i As Integer = 0 To FormularioParaCambiar.Controls.Count - 1 Step 1
            If TypeOf FormularioParaCambiar.Controls(i) Is TableLayoutPanel Then
                For j As Integer = 0 To FormularioParaCambiar.Controls(i).Controls.Count - 1 Step 1
                    If TypeOf FormularioParaCambiar.Controls(i).Controls(j) Is TextBox Then
                        With FormularioParaCambiar.Controls(i).Controls(j)
                            .Margin = New Padding(0, 50, 50, 0)
                            .BackColor = ColorSecundario
                            .ForeColor = ColorLetrasSecundario
                            .Font = FuenteTextos
                        End With
                    End If
                Next
            End If
        Next

    End Sub

    Public Sub SombrearLabel(sender As Object, e As EventArgs)
        sender.BackColor = ColorSecundario
    End Sub

    Public Sub QuitarSombraLabel(sender As Object, e As EventArgs)
        sender.BackColor = ColorPrincipal
    End Sub






End Module
