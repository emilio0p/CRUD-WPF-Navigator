   M S B A M L   `   `   `  ����\  XEmilioOrdunaPena_ProyectoFinal2EV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:EmilioOrdunaPena_ProyectoFinal2EV.Pages'EmilioOrdunaPena_ProyectoFinal2EV.Pages  5      3    -EmilioOrdunaPena_ProyectoFinal2EV.Pages.Page2   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:EmilioOrdunaPena_ProyectoFinal2EV.Pages     5        N� Title$  Page2��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.6* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ btnConsulta1��5      $��Productos más vendidos��5   ,   
����������	#FF80B198$
��0,25q�6x   $��35��6�   $	��250��6�   $��0��5      $��0��6   $U��O/EmilioOrdunaPena_ProyectoFinal2EV;component/Fonts/Poppins-SemiBold.ttf#Poppins)�6.   ��5      �� 5       �� 
TargetType" ��6   .�5       ��  �� Property � �� �� Value 5!      �� 5"       �� 
TargetType" ��6.   .R�5#   "   ��  ��Name$ LoginBorder��6)   #��z��6>   	 �� CornerRadius$	 16��5$      ._�5%   &   �� $��Center=�67   $��Center=�5&   '   5'   #   
 �� Triggers
 5(   "   P� 5)   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5*   *   ��  �� 
TargetName$ LoginBorder��6W    � �� �#7ba85e�� 5+   *   $ LoginBorder��6`    � ��
 �   ��� 5,   *    �@�Cursor$
 Hand��6C   5-   '   5/      51      52      54      �� 57   
   -   5        $ btnConsulta2��57      $��Productos sin stock��58   %   
����������	#FF80B198$
��0,25q�6n   $��35��6|   $	��250��6�   $��0��59   	   $��1��6   $U��O/EmilioOrdunaPena_ProyectoFinal2EV;component/Fonts/Poppins-SemiBold.ttf#Poppins)�6&   ��5;      �� 5<      " ��6   .�5=      ��  � �� 5>      �� 5?      " ��6.   .R�5@   "   �� $ LoginBorder��6)   #��z��6>   $	 16��5A      ._�5B   &   �� $��Center=�67   $��Center=�5C      5D   #   
 5E   "   P� 5F   &    �@J�IsMouseOver$
 True��6E   . �5G   *   �� $ LoginBorder��6W    � �� �#7ba85e�� 5H   *   $ LoginBorder��6`    � ��
 �   ��� 5I   *    �@�Cursor$
 Hand��6C   5J   '   5L      5N      5O      5Q      �� 5T   
   -   5        $ btnConsulta3��5T      $��Productos más caros��6C   
����������	#FF80B198$
��0,25q�6�   $��35��5U      $	��250��6   $��0��6)   $��2��66   $U��O/EmilioOrdunaPena_ProyectoFinal2EV;component/Fonts/Poppins-SemiBold.ttf#Poppins)�6F   ��5W      �� 5X      " ��6   .�5Y      ��  � �� 5Z      �� 5[      " ��6.   .R�5\   "   �� $ LoginBorder��6)   #��z��6>   $	 16��5]   	   ._�5^   &   �� $��Center=�67   $��Center=�5_      5`   #   
 5a   "   P� 5b   &    �@J�IsMouseOver$
 True��6E   . �5c   *   �� $ LoginBorder��6W    � �� �#7ba85e�� 5d   *   $ LoginBorder��6`    � ��
 �   ��� 5e   *    �@�Cursor$
 Hand��6C   5f   '   5h      5j      5k      5m      &   System.Windows.Controls.DataGrid  5t   
   -   5          Name$ tablaProductos2��5t         AutoGenerateColumns$
 True��6,   $��1��6G   $��2��6T   $��0��6e   $��3��5u      $��3q�6(   ���	#FF80B198   
IsReadOnly$
 True��6T      PoppinsFontRegular#��[  6f   5w      5|      5}      