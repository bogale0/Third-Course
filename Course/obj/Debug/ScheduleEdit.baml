   M S B A M L   `   `   `  ����A  =Course, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CourseCourse  5          Course.ScheduleEdit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Course     5      -   5          N� 
Background
  ��d� N� FontSize$ 14(�5   A   .��5      � .+�5   
   �� $)��#Расписание занятий��6   $
��Bold"�6-   $��
0,10,143,0q�6?   $��18(�6S   $��Right=�6a   $	��Top=�6}   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ table��5      $	��450��6"      AutoGenerateColumns .     CanUserAddRows .  $��Right=�6a   $��
0,53,10,10q�6}      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Аудитория��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *room+  5      $ Состояние��6%   $	 100 68    6D   �� *state+  5      $ Группа��6%   $ 75 65    6@   �� *	groupName+  5      $  Преподаватель��6%   $	 150 6<    6H   �� *	teacher+5      �� 5   
   $��Center=�6   $
��Left=�60   $��	105,0,0,0q�6K   .+�5      �� $��День��6   $
��Bold"�6#   �� 5      -   5        	 ��Name$	 	dayChosen��5      $	��130��6O   .@�5      �� $��Понедельник��6   �� 5      $��Вторник��6   �� 5      $��
Среда��6   �� 5      $��Четверг��6   �� 5      $��Пятница��6   �� 5      $��Суббота��6   5      �� 5       $��Номер пары��6   $
��Bold"�6)   $��0,10,0,0q�6;   �� 5!      -   5        $	 classChosen��5!      $	��130��6Q   .@�5"      �� $��1��6   �� 5#      $��2��6   �� 5$      $��3��6   �� 5%      $��4��6   �� 5&      $��5��6   5'      �� 5(      -   5        
 ��Name$
 
saveButton��5(      $��Сохранить��6)   $��0,30,0,0q�6=   $��Center=�6c    � Cursor$
 Hand��6�   �� 5)      -   5        $��
Назад��5)      $��0,20,0,0q�6%   $��Center=�6F   5*      5+      5,      