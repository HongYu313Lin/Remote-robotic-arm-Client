# Remote-robotic-arm-Client
Remote-robotic-arm-Client
開啟程式後輸入IP及port. 並將Autojoy打勾了再按下connect即可操作手臂。

有對應按鍵的搖桿

Logitech 羅技 F310 GAMEPAD  (背面有X跟D兩個模式可以切換 若沒有對應到按鈕請自行切換)

SONY PS4 DUALSHOCK 4

其他搖桿的對應按鍵請自行修改程式

請在 joystation.cs

找到 joy_event_captur()

修改 joyGetPosEx(button_id, ref jsx);之後的  jsx 所取得的按鍵資料
