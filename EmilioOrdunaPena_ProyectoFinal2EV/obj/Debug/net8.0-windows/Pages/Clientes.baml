   M S B A M L   `   `   `  ����\  XEmilioOrdunaPena_ProyectoFinal2EV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:EmilioOrdunaPena_ProyectoFinal2EV.Pages'EmilioOrdunaPena_ProyectoFinal2EV.Pages  5      6    0EmilioOrdunaPena_ProyectoFinal2EV.Pages.Clientes   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:EmilioOrdunaPena_ProyectoFinal2EV.Pages     5        N� Title$  Clientes��5	      .��5      � 
�������.+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6-   .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   63   �� 5      $��* �6'   63   .+�5      �� -   5         ��Name$ btnAgregarCliente��5   D   $��Center=�6   $��0��64   $��Agregar cliente��6   
����������	#FF80B198$
��0,25q�6�   $��35��6�   $	��250��6�   $U��O/EmilioOrdunaPena_ProyectoFinal2EV;component/Fonts/Poppins-SemiBold.ttf#Poppins)�5      ��5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value 5   "   �� 5   &    �� 
TargetType" ��66   .R�5   *   ��  ��Name$ LoginBorder��61   #��z��6F   	 �� CornerRadius$	 16��5      ._�5   .   �� $��Center=�6?   $��Center=�5       5!   +   
 �� Triggers
 5"   *   P� 5#   .    P� Property �@J�IsMouseOver P� Value$
 True��6M   . �5$   2   ��  �� 
TargetName$ LoginBorder��6_    � �� �#7ba85e�� 5%   2   $ LoginBorder��6h    � ��
 �   ��� 5&   2    �@�Cursor$
 Hand��6K   5'   /   5)   '   5+      5,      5.      �� 50      -   5        $ btnRecargarClientes��50   D   $��Center=�6   $��1��64   $	��↻��6�   
����������	#FF80B198$
��0,25q�6�   $��35��6�   $	��100��6�   $V��P/EmilioOrdunaPena_ProyectoFinal2EV;component/Fonts/Poppins-ExtraBold.ttf#Poppins)�51      $��25(�6_   ��53      �� 54      " ��6    .�55      ��  � �� 56   "   �� 57   &   " ��66   .R�58   *   �� $ LoginBorder��61   #��z��6F   $		 100��59      ._�5:   .   �� $��Center=�6?   $��Center=�5;      5<   +   
 5=   *   P� 5>   .    �@J�IsMouseOver$
 True��6M   . �5?   2   �� $ LoginBorder��6_    � �� �#7ba85e�� 5@   2   $ LoginBorder��6h    � ��
 �   ��� 5A   2    �@�Cursor$
 Hand��6K   5B   /   5D   '   5F      5G      5I      5J      &   System.Windows.Controls.DataGrid  5M      -   5          Name$ tablaClientes��5M   2   $��Center=�6      AutoGenerateColumns$
 True��6I   $��3q�6d   ���	#FF80B198   PoppinsFontRegular#��[  6�      
IsReadOnly$
 True��6�   5O      5P      5Q      5S      