   M S B A M L   `   `   `  ����A  =Course, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CourseCourse  5          Course.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Course     5      -   5          N� 
Background
  ��d� N� FontSize$ 14(�5   =    N� Title$ MainPage��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ table��5      $	��450��6"      AutoGenerateColumns .     CanUserAddRows .  $
��Left=�6a   $��
10,53,0,10q�6|      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Аудитория��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 68   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6D   �� *room+  5      $ Состояние��6%   $	 100 68   	 6D   �� *state+  5      $ Группа��6%   $ 75 65   	 6@   �� *	groupName+  5      $  Преподаватель��6%   $	 150 6<   	 6H   �� *	teacher+5      �� 5   
   $��Center=�6   $
��Left=�60   $��	565,0,0,0q�6K   .+�5      �� $��Дата��6   $
��Bold"�6#   (  "System.Windows.Controls.DatePicker  5      -   5        
  Name$
 
dateChosen��5      $	��130��6V   $��0,0,0,10q�6b   �� 5      $��Номер пары��6   $
��Bold"�6)   �� 5      -   5         ��Name$ classChosen��5      $	��130��6R   $��0,0,0,30q�6^   .@�5      �� $��1��6   �� 5      $��2��6   �� 5      $��3��6   �� 5      $��4��6   �� 5      $��5��6   5      �� 5       -   5         ��Name$ 
saveButton��5       $��Сохранить��6)   $��0,0,0,20q�6=   $��Center=�6c   �� 5!      -   5        $��
Выйти��5!      $��Center=�66   5"      o� 5$   
   $	��Top=�6   $
��Left=�6'   .@�5%      m� -   5         m�Name$ 	menuRooms��5%      $��Аудитории��6*   6=   m� 5&      -   5        $ menuSchedule��5&      $��Расписание��6-   6A   m� 5'      -	   5        $ menuUser��5'      $��Пользователи��6)   6?   m� 5(      $��Экспорт��6   5)      5*      5+      