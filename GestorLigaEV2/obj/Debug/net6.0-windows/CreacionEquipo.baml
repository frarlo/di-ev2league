   M S B A M L   `   `   `  ����H  DGestorLigaEV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GestorLigaEV2GestorLigaEV2  5      -clr-namespace:GestorLigaEV2GestorLigaEV2  5      "    GestorLigaEV2.CreacionEquipo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:GestorLigaEV2     5      /controlclr-namespace:GestorLigaEV2     5        N� Title$  Creacion Equipo��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   $   GestorLigaEV2.ControlTextBlock  $��0��6!   $��2��61   $��0��6E   �� 5   
   $��1��6   $��0��6!   $��Nombre del Equipo��61   $��Center=�6J   $��Center=�6g   �� 5!   
   -   5         ��Name$ nombreEquipo��5!      $��1��6G   $��1��6T   �� 5#   
   $��2��6   $��0��6!   $��Año de la Fundación��61   $��Center=�6L   $��Center=�6i   �� 5%   
   -   5        $ añoFundacion��5%      $��2��6I   $��1��6V   �� 5'   
   $��3��6   $��0��6!   $��Nombre del Estadio��61   $��Center=�6K   $��Center=�6h   �� 5)   
   -   5        $ estadioEquipo��5)      $��3��6H   $��1��6U   �� 5+   
   $��4��6   $��0��6!   $��Escudo del Equipo��61   $��Center=�6J   $��Center=�6g   �� 5-   
   -   5        $��Seleccionar archivo...��5-         templateButton#��[  62   $��4��6]   $��1��6j   $��	5,10,5,10q�6z   6�   �� 5/   
   -   5        $��Borrar campos��5/      #��[  6*   $��5��6U   $��0��6b   6r   &    GestorLigaEV2.CustomControlBoton  52   
   -   5          Name$ CustomControlBoton��52   %   &    GestorLigaEV2.CustomControlBoton   Click$ CrearEquipo_Click��6u   $��Crear Equipo��6A   $��5��6X   $��1��6e   $��	5,10,5,10q�6�   54      56      