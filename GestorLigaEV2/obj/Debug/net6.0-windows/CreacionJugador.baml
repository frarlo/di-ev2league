   M S B A M L   `   `   `  ����H  DGestorLigaEV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GestorLigaEV2GestorLigaEV2  5      -clr-namespace:GestorLigaEV2GestorLigaEV2  5      #    GestorLigaEV2.CreacionJugador   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:GestorLigaEV2     5      /controlclr-namespace:GestorLigaEV2     5        N� Title$  Creación de Jugadores��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5!   
   %   GestorLigaEV2.ControlTextBlock2  $��0��6"   $��2��62   $��0��6F   �� 5#   
   $��1��6   $��0��6!   $��Nombre del Jugador��61   $��Center=�6K   $��Center=�6h   �� 5%   
   -   5         ��Name$ nombreJugador��5%      $��1��6H   $��1��6U   �� 5'   
   $��2��6   $��0��6!   $��Apellidos de Jugador��61   $��Center=�6M   $��Center=�6j   �� 5)   
   -   5        $ apellidosJugador��5)      $��2��6K   $��1��6X   �� 5+   
   $��3��6   $��0��6!   $��Apodo del Jugador��61   $��Center=�6J   $��Center=�6g   �� 5-   
   -   5        $ apodoJugador��5-      $��3��6G   $��1��6T   �� 5/   
   $��4��6   $��0��6!   $��Edad del Jugador��61   $��Center=�6I   $��Center=�6f   �� 51   
   -   5        $ edadJugador��51      $��4��6H   $��1��6U   �� 53   
   $��5��6   $��0��6!   $��Dorsal del Jugador��61   $��Center=�6K   $��Center=�6h   �� 55   
   -   5        $ dorsalJugador��55      $��5��6J   $��1��6W   �� 57   
   $��6��6   $��0��6!   $��Nacionalidad del Jugador��61   $��Center=�6Q   $��Center=�6n   �� 59   
   -   5        $ nacionalidadJugador��59      $��6��6N   $��1��6[   �� 5;   
   $��7��6   $��0��6!   $��Equipo del Jugador��61   $��Center=�6K   $��Center=�6h   �� 5=   
   -   5         ��Name$ equipoJugador��5=      $��7��6*   $��1��67    �� DisplayMemberPath$ Nombre��6p   ��6G   �� *coleccionEquipos+6p   �� 5?   
   $��8��6   $��0��6!   $��Imagen del Jugador��61   $��Center=�6K   $��Center=�6h   �� 5A   
   -   5        $��Seleccionar archivo...��5A         templateButton#��[  62   $��8��6]   $��1��6j   $��10,10,10,10q�6z   6�   �� 5C   
   -	   5        $��Borrar campos��5C      #��[  6)   $��9��6T   $��0��6a   6q   &    GestorLigaEV2.CustomControlBoton  5E   
   -
   5          Name$ CustomControlBoton��5E   %   &    GestorLigaEV2.CustomControlBoton   Click$ CrearJugador_Click��6v   $��Crear Jugador��6A   $��9��6Y   $��1��6f   $��10,10,10,10q�6�   5G      5H      