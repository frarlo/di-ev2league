   M S B A M L   `   `   `  ����H  DGestorLigaEV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GestorLigaEV2GestorLigaEV2  5      $    GestorLigaEV2.MostrarJugadores   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:GestorLigaEV2     5        N� Title$  Gestión de Jugadores��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $��1* �6   �� 5      $
��0.1* �6   .+�5   
   �� $��0��6   $J��DEdita los campos correspondientes o elimina el jugador con el botón��6!   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ listaJugadores��5   !   $��1��6      AutoGenerateColumns$ False��69      HeadersVisibility$ Column=�6U      CanUserAddRows$ False��6p      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Nombre+6P     5      $ 	Apellidos��6%   $
	 1.5* 6V   
 68   �� *	Apellidos+6V     5      $ Apodo��6%   $	 1* 6N   
 64   �� *Apodo+6N     5      $
 Edad��6%   $
	 0.5* 6L   
 63   �� *Edad+6L     5      $ Dorsal��6%   $
	 0.5* 6P   
 65   �� *Dorsal+6P     5      $ Nacionalidad��6%   $	 1* 6\   
 6;   �� *Nacionalidad+6\   4  .System.Windows.Controls.DataGridTemplateColumn  5"      $ Equipo��6)   $	 2* 69      CellTemplate 5$      �� 5&      .R�5*      ��  �� DisplayMemberPath$ Nombre��5+   '   ��5*   '   �� *DataContext.coleccionEquipos+ �� RelativeSource ��  �� AncestorType" N� �� SelectedItem 5,   '   �� *	EquipoSel+ �� Mode$ TwoWay=�5/      53        56      $ Imagen��6)   $	 1* 69    59      �� 5;      .R�5=      ��  �� Orientation$ 
Horizontal=�6)   .+�5?   "   �� $��50��6B   $��50��6M   ��6(   �� *Imagen+6M   �� 5@   "   -   5        $��Editar��5@   )   6:   5B      5D      5H      5L      �� 5N   
   -   5         ��Name$ botonEliminar��5N   K   $��2��6      templateEliminar#��[  6   $#��Eliminar jugador seleccionado��6b   6�   5P      5R      