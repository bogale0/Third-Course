   M S B A M L   `   `   `  ����A  =Course, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CourseCourse  5          Course.UsersList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Course     5        N� 
Background
  ��d� N� FontSize$ 14(�5   >    N� Title$ 	UsersList��5	      .��5      � .+�5   
   �� $��Center=�6   $��Center=�62   .+�5      �� $-��'Список пользователей��6   $
��Bold"�63   $��18(�6E   $��Center=�6S   $��0,0,0,10q�6p   &   System.Windows.Controls.DataGrid  5      -   5          Name$ table��5      $	��300��6&   $	��300��62      AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Логин��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 150 68   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6D   �� *login+  5      $ Привелегии��6)   $		 150 6=   
 6I   �� *
Roles.name+5      �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��0,10,0,0q�6O   .+�5      �� -   5        $��Удалить��5      $	��100��6>   $��0,0,10,0q�6J   �� 5      -   5        $��
Назад��5      $	��100��68   5      5      5      5      