   M S B A M L   `   `   `  ����\  XEmilioOrdunaPena_ProyectoFinal2EV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:EmilioOrdunaPena_ProyectoFinal2EV.Pages'EmilioOrdunaPena_ProyectoFinal2EV.Pages  5      3    -EmilioOrdunaPena_ProyectoFinal2EV.Pages.Page1   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:EmilioOrdunaPena_ProyectoFinal2EV.Pages     5        N� Title$  Page1��5	       � 	Resources 5         PlaceholderTextBoxStyle �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels ��Name ��Name
	 � Tag
 �� Triggers P� Property P� Value �� 
TargetName��%  &	        �� 5   
   " ��60   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� #��z��6%   #��z��5      #��z��5      $
 true��5      �� 5      $ PART_ContentHost��6+   # z 5   #   �� 5      $ Placeholder��6(   #��z	 5       
�������$y�	Collapsed=�5       $��2q�5   (   5      
 5      P� 5        � ��$  ��66   . �5!   "   �� $ Placeholder��6)    � y�$ Visible=�6X   5"      5$      5&      5'      5)      .��5+      � 
������� � RowDefinitions 5-   
   �� 5.      $
��0.6* �6   �� 5/      $��* �6   �� 50      $��* �6    � ColumnDefinitions 53   
   �� 54      $��* �6   �� 55      $��* �6   �� 56      $��* �6   .+�59   
   �� -   5         ��Name$ btnAgregarRegistro��59      $��Agregar producto��5:   2   
����������	#FF80B198$
��0,25q�6x   $��35��6�   $	��250��6�   $��0��5;      $��0��6   $U��O/EmilioOrdunaPena_ProyectoFinal2EV;component/Fonts/Poppins-SemiBold.ttf#Poppins)�6.   ��5=      �� 5>      " ��6   .�5?      ��  � �� 5@      �� 5A      " ��6.   .R�5B   "   ��  ��Name$ LoginBorder��6)   #��z��6>    �� CornerRadius$ 16��5C      ._�5D   &   �� $��Center=�67   $��Center=�5E   '   5F   #   
 5G   "   P� 5H   &    �@J�IsMouseOver$
 True��6E   . �5I   *   �� $ LoginBorder��6W    � �� �#7ba85e�� 5J   *   $ LoginBorder��6`    � ��
 �   ��� 5K   *    �@�Cursor$
 Hand��6C   5L   '   5N      5P      5Q      5S      �� 5V   
   -   5        $��listaCategorias��5V   H   $��0��6   $��35��6    $	��250��6,   $��1��68   $��Center=�6_   $��Center=�6|   $	��165��6�   .@�5W      �� -   5        $��catPorDefecto��5W   >   $��Selecciona una categoría��6    �� 
IsSelected$
 True��6S   6g   ��5Z      �� 5[      " ��6   .�5\      ��  � ��
 �����63   �� 5]       � �� �	#FF80B19863   �� 5^       � ��$
 0,25q�6/   �� 5_       � ��$ 35��6/   �� 5`       � ��$	 165��6.   �� 5a       � ��$ Center=�6<   �� 5b       � ��$ Center=�6:   �� 5c       � ��$U O/EmilioOrdunaPena_ProyectoFinal2EV;component/Fonts/Poppins-SemiBold.ttf#Poppins)�63   �� 5d       �@�FocusVisualStyle 69   Z� �� 5e       � �� 5f      �� 5g      " ��6.   .R�5h   "   �� $ ComboBoxBorder��6)   #��z��6A   ���	#FF80B198$��1q�6�   ._�5i   &   � .+�5j   *   d�  d�Name$ ToggleButton��67   
������ $��0q�6f    �� 	ClickMode$ Press=�6z   $|�false��6�   
������� d� 	IsChecked 6�   ��  �� Path$ IsDropDownOpen� �� Mode$ TwoWay=� �� RelativeSource �� *TemplatedParent+.��5l   .   �  5m   2   �� 5n   6   $��* �6G   �� 5o   6   $
��Auto �6G   .+�5q   2   �� ��6<   �� *SelectedItem.Content+ ��  �� Mode$ FindAncestor=� �� AncestorType" ��F� 5r   2    F�Name$ Arrow��67   $��1��6F   
�������$��Center=�6c   $��Center=�6�   $��10,0,0,0q�6�   =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	6�   5s   /   5u   +   � 5v   *    �Name$ Popup��60   $��Bottom=�6?   $|�False��6R    � AllowsTransparency$
 True��6d    �� IsDropDownOpen#��z 6~   $��Slide=�6�   .��5w   .   � $��DropDown��63   $
 True��6C     � ActualWidth#��z  6^   ! �� MaxDropDownHeight#��z! 6�   .+�5x   2   �� $ DropDownBorder��69   ���	#FF80B198$��1q�6h   �� 5y   2   $��DropDownScrollViewer��6?   .��5z   6   �� 5{   3   5|   /   5}   +   5~   '   5   #   
 5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   �� $ ComboBoxBorder��6W    � �� �#7ba85e�� 5�   *   $ ToggleButton��6W    � �� �#7ba85e�� 5�   *    �@�Cursor$
 Hand��6C   5�   '   P� 5�   &    �@��IsDropDownOpen$
 True��6H   . �5�   *   �� $ ToggleButton��6a    � ��
 �   �5�   '   P� 5�   &    � {�$ False��6C   . �5�   *   �� $ ToggleButton��6a    � ��
 �����5�   '   P� 5�   &    �@��HasItems$ False��6B   . �5�   *   �� $ ToggleButton��6a    � ��
 �����5�   '   5�      5�      5�      5�      &   System.Windows.Controls.DataGrid  5�   
   -   5        "  Name$" tablaProductos��5�      #   AutoGenerateColumns$
# True��6+   $��1��6F   $��2��6S   $��0��6d   $��3��5�      $��3q�6(   ���	#FF80B198  PoppinsFontRegular#��[ 6�   $   
IsReadOnly$
$ True��6�   5�      � 5�   
   $��2��6   $��Center=�6   $��Center=�6:   ���	#FF80B198$��90��6n   $	��266��6z    5�      �� 5�      $
��0.5* �6    �� 5�      $��1* �6     5�      �� 5�      $��1* �6#   �� 5�      $��1* �6#   .+�5�      �� $��Buscar producto��6   $��0��6/     PoppinsFontBold#��[ 6<   
�������$��5,0,0,0q�6x   $��2��6�   $��Center=�6�   $��20(�6�   6�   �� 5�      -   5        % ��Name$% 	txtBuscar��5�      $��1��6)   $��0��66   $	��100��6F   $��20��6R   #��[  6^   $	 Buscar nombre...��5�   
   $��2��6!   $��10,20,100,21q�65   6M   �� 5�      -   5        $��	btnBuscar��5�      $��1��5�   -   $��1��6:   $��Buscar��6J   $��15,12,14,13q�6[   
���   �
�������$U��O/EmilioOrdunaPena_ProyectoFinal2EV;component/Fonts/Poppins-SemiBold.ttf#Poppins)�5�      ��5�      �� 5�      " ��6   .�5�      ��  � �� 5�      �� 5�   "   " ��62   .R�5�   &   �� $ LoginBorder��6-   #��z��6B   $ 16��6l   ._�5�   *   �� $��Center=�6;   $��Center=�5�   '   5�   '   
 5�   &   P� 5�   *    �@J�IsMouseOver$
 True��6I   . �5�   .   �� $ LoginBorder��6[    � �� �#7ba85e�� 5�   .   $ LoginBorder��6d    � ��
 ������� 5�   .    �@�Cursor$
 Hand��6G   5�   +   5�   #   5�      5�      5�      5�      5�      5�      