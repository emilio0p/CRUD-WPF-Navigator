   M S B A M L   `   `   `  ����\  XEmilioOrdunaPena_ProyectoFinal2EV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:EmilioOrdunaPena_ProyectoFinal2EV!EmilioOrdunaPena_ProyectoFinal2EV  5   	   1    +EmilioOrdunaPena_ProyectoFinal2EV.AddWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:EmilioOrdunaPena_ProyectoFinal2EV     5   	     � Icon$  /Media/logo.png��5       � Title$ Agregar producto��5	      $	��241��6   $
��1512��6+   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��Nombre:��6   $��0��6#   $��Center=�63      PoppinsFontSemiBold#��[  6P   6   �� 5   
   -   5         ��Name$ 	txtNombre��5      $	��150��6%   $��0��62   $��Nombre del producto��6B   $��20(�6]   $��10,10,10,10q�6k    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $��Center=�6�   �� 5   
   $��Descripción:��6   $��1��6(   $��Center=�68   #��[  6U   6�   �� 5   
   -   5        $ txtDesc��5      $	��150��6#   $��1��60   $��Descripción del producto��6@   $��10,10,10,10q�6`   $��20(�6u   $��Center=�6�   $��Center=�6�   $
 Wrap=�6�   �� 5   
   $��Precio:��6   $��2��6#   $��Center=�63   #��[  6P   6   �� 5   
   -   5        $ 	txtPrecio��5      $	��150��6%   $��2��62   $��Precio del producto��6B   $��10,10,10,10q�6]   $��20(�6r   $��Center=�6�   $��Center=�6�   $
 Wrap=�6�   �� 5   
   $��Imagen:��6   $��3��6#   $��Center=�63   #��[  6P   6   �� 5   
   -   5        $ 	txtImagen��5      $	��150��6%   $��3��62   $��Imagen del producto��6B   $��10,10,10,10q�6]   $��20(�6r   $��Center=�6�   $��Center=�6�   $
 Wrap=�6�   �� 5!   
   $��Unidades en stock:��6   $��4��6.   $��Center=�6>   #��[  6[   6�   �� 5"   
   -   5        $ txtStock��5"      $	��150��6$   $��4��61   $��Stock del producto��6A   $��10,10,10,10q�6[   $��20(�6p   $��Center=�6~   $��Center=�6�   $
 Wrap=�6�   �� 5$   
   $��Id categoria:��6   $��5��6)   $��Center=�69   #��[  6V   6�   �� 5%   
   -   5        $ txtCategoria��5%      $	��150��6(   $��5��65   $��Categoria del producto��6E   $��10,10,10,10q�6c   $��20(�6x   $��Center=�6�   $��Center=�6�   $
 Wrap=�6�   � 5)   
   $��6��6   $��10q�6   .+�5*      �� -   5         ��Name$ 
btnAgregar��5*      $��Agregar registro��6)   $��10q�6D   $	��100��6P     PoppinsFontBold#��[ 6w   
������6�   5+      5-      5.      