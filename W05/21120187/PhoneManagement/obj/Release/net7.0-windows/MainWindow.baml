   M S B A M L   `   `   `  ���� J  FPhoneManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PhoneManagementPhoneManagement  E'clr-namespace:PhoneManagement.ConverterPhoneManagement.Converter       PhoneManagement.MainWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:PhoneManagement     :local1'clr-namespace:PhoneManagement.Converter     -     � Title$  
MainWindow��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � 	Resources ;  5PhoneManagement.Converter.RelativeToAbsoluteConverter   absoluteConverter��%   &	          .��� 
������� � RowDefinitions �� $
��0.5* ��� $��3* �.+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� -   $��AddPhone��$��1��$��10, 0, 10,0q�$	��130��$��30��  MyButtonStyle#��[ $	��0.5q�
���  ��$��Center=�.���� $ 
Horizontal=�.+��� $��Medium"�
���  ��$��Center=�	Add Phone�� -   $��UpdatePhone��$��1��$��10, 0, 10,0q�$	��130��$��30��#��[ $	��0.5q�
���  ��$��Center=�.���� $ 
Horizontal=�.+��� $��Medium"�
���  ��$��Center=�Update Phone�� -   $��RemovePhone��$��1��$��10, 0, 10,0q�$	��130��$��30��#��[ $	��0.5q�
���  ��$��Center=�.���� $ 
Horizontal=�.+��� $��Medium"�
���  ��$��Center=�Remove Phone�� $��1�����	#60ffffff �� CornerRadius$ 20��$��25 10 25 25q�._��  � ColumnDefinitions �� $��0.20* ��� $��3* � �� $��50 ��� $��0.15* ��� .+��� $��List Of Mobile Phone��$��15, 5, 5, 0q�$��2�����#8B4000$��Center=�$��16(�$
��Bold"�$��Segoe UI)�� $��0��$��2��$��1��$��10, 0, 10, 0q� �� $
��0.6* ��� �� �� .+��� $��Center=�$ 
Horizontal=�$��Center=�$��0 0 0 0q�.+��� $��Image��$��12(�$
��Bold"����#353935�� $��0, 0,0,0q�$��Center=�$��Center=�$ 
Horizontal=�$��1��.+��� $
��Name��$��Center=�$��12(�$
��Bold"����#353935�� $��0, 0,0,0q�$��Center=�$��Center=�$ 
Horizontal=�$��2��.+��� $��Price��$��Center=�$��12(�$
��Bold"����#353935�� $��0, 0,0,0q�$��Center=�$��Center=�$ 
Horizontal=�$��3��.+��� $��Manufacturer��$��Center=�$��12(�$
��Bold"����#353935�� -   $��phoneListView��$��0q�$��2��$��0��$��2��$��Disabled=�
������ ���� .R�� $��85��$��10, 0, 10, 0q����� *ActualWidth+ �� ElementName$ phoneListView�� �� $
��0.6* ��� $��1* ��� $��1* ��� $��1* �.+��� $��Center=����� *	ImagePath+ �� 	Converter# [  �� $��1��$��Medium"����#353935$��Center=�$��Center=����� *Name+�� $��2��$��Medium"����#353935$��Center=�$��Center=����� *Price+�� $��3��$
��Wrap=�$��Medium"�$��Center=�$��Center=����#353935���� *Manufacturer+���� 	 �� 
TargetType"	 ��.�-   