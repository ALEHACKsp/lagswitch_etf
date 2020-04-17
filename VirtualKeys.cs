using System;

// Token: 0x02000002 RID: 2
public enum VirtualKeys : ushort
{
	// Token: 0x04000002 RID: 2
	LeftButton = 1,
	// Token: 0x04000003 RID: 3
	RightButton,
	// Token: 0x04000004 RID: 4
	Cancel,
	// Token: 0x04000005 RID: 5
	MiddleButton,
	// Token: 0x04000006 RID: 6
	ExtraButton1,
	// Token: 0x04000007 RID: 7
	ExtraButton2,
	// Token: 0x04000008 RID: 8
	Back = 8,
	// Token: 0x04000009 RID: 9
	Tab,
	// Token: 0x0400000A RID: 10
	Clear = 12,
	// Token: 0x0400000B RID: 11
	Return,
	// Token: 0x0400000C RID: 12
	Shift = 16,
	// Token: 0x0400000D RID: 13
	Control,
	// Token: 0x0400000E RID: 14
	Menu,
	// Token: 0x0400000F RID: 15
	Pause,
	// Token: 0x04000010 RID: 16
	CapsLock,
	// Token: 0x04000011 RID: 17
	Kana,
	// Token: 0x04000012 RID: 18
	Hangeul = 21,
	// Token: 0x04000013 RID: 19
	Hangul = 21,
	// Token: 0x04000014 RID: 20
	Junja = 23,
	// Token: 0x04000015 RID: 21
	Final,
	// Token: 0x04000016 RID: 22
	Hanja,
	// Token: 0x04000017 RID: 23
	Kanji = 25,
	// Token: 0x04000018 RID: 24
	Escape = 27,
	// Token: 0x04000019 RID: 25
	Convert,
	// Token: 0x0400001A RID: 26
	NonConvert,
	// Token: 0x0400001B RID: 27
	Accept,
	// Token: 0x0400001C RID: 28
	ModeChange,
	// Token: 0x0400001D RID: 29
	Space,
	// Token: 0x0400001E RID: 30
	Prior,
	// Token: 0x0400001F RID: 31
	Next,
	// Token: 0x04000020 RID: 32
	End,
	// Token: 0x04000021 RID: 33
	Home,
	// Token: 0x04000022 RID: 34
	Left,
	// Token: 0x04000023 RID: 35
	Up,
	// Token: 0x04000024 RID: 36
	Right,
	// Token: 0x04000025 RID: 37
	Down,
	// Token: 0x04000026 RID: 38
	Select,
	// Token: 0x04000027 RID: 39
	Print,
	// Token: 0x04000028 RID: 40
	Execute,
	// Token: 0x04000029 RID: 41
	Snapshot,
	// Token: 0x0400002A RID: 42
	Insert,
	// Token: 0x0400002B RID: 43
	Delete,
	// Token: 0x0400002C RID: 44
	Help,
	// Token: 0x0400002D RID: 45
	N0,
	// Token: 0x0400002E RID: 46
	N1,
	// Token: 0x0400002F RID: 47
	N2,
	// Token: 0x04000030 RID: 48
	N3,
	// Token: 0x04000031 RID: 49
	N4,
	// Token: 0x04000032 RID: 50
	N5,
	// Token: 0x04000033 RID: 51
	N6,
	// Token: 0x04000034 RID: 52
	N7,
	// Token: 0x04000035 RID: 53
	N8,
	// Token: 0x04000036 RID: 54
	N9,
	// Token: 0x04000037 RID: 55
	A = 65,
	// Token: 0x04000038 RID: 56
	B,
	// Token: 0x04000039 RID: 57
	C,
	// Token: 0x0400003A RID: 58
	D,
	// Token: 0x0400003B RID: 59
	E,
	// Token: 0x0400003C RID: 60
	F,
	// Token: 0x0400003D RID: 61
	G,
	// Token: 0x0400003E RID: 62
	H,
	// Token: 0x0400003F RID: 63
	I,
	// Token: 0x04000040 RID: 64
	J,
	// Token: 0x04000041 RID: 65
	K,
	// Token: 0x04000042 RID: 66
	L,
	// Token: 0x04000043 RID: 67
	M,
	// Token: 0x04000044 RID: 68
	N,
	// Token: 0x04000045 RID: 69
	O,
	// Token: 0x04000046 RID: 70
	P,
	// Token: 0x04000047 RID: 71
	Q,
	// Token: 0x04000048 RID: 72
	R,
	// Token: 0x04000049 RID: 73
	S,
	// Token: 0x0400004A RID: 74
	T,
	// Token: 0x0400004B RID: 75
	U,
	// Token: 0x0400004C RID: 76
	V,
	// Token: 0x0400004D RID: 77
	W,
	// Token: 0x0400004E RID: 78
	X,
	// Token: 0x0400004F RID: 79
	Y,
	// Token: 0x04000050 RID: 80
	Z,
	// Token: 0x04000051 RID: 81
	LeftWindows,
	// Token: 0x04000052 RID: 82
	RightWindows,
	// Token: 0x04000053 RID: 83
	Application,
	// Token: 0x04000054 RID: 84
	Sleep = 95,
	// Token: 0x04000055 RID: 85
	Numpad0,
	// Token: 0x04000056 RID: 86
	Numpad1,
	// Token: 0x04000057 RID: 87
	Numpad2,
	// Token: 0x04000058 RID: 88
	Numpad3,
	// Token: 0x04000059 RID: 89
	Numpad4,
	// Token: 0x0400005A RID: 90
	Numpad5,
	// Token: 0x0400005B RID: 91
	Numpad6,
	// Token: 0x0400005C RID: 92
	Numpad7,
	// Token: 0x0400005D RID: 93
	Numpad8,
	// Token: 0x0400005E RID: 94
	Numpad9,
	// Token: 0x0400005F RID: 95
	Multiply,
	// Token: 0x04000060 RID: 96
	Add,
	// Token: 0x04000061 RID: 97
	Separator,
	// Token: 0x04000062 RID: 98
	Subtract,
	// Token: 0x04000063 RID: 99
	Decimal,
	// Token: 0x04000064 RID: 100
	Divide,
	// Token: 0x04000065 RID: 101
	F1,
	// Token: 0x04000066 RID: 102
	F2,
	// Token: 0x04000067 RID: 103
	F3,
	// Token: 0x04000068 RID: 104
	F4,
	// Token: 0x04000069 RID: 105
	F5,
	// Token: 0x0400006A RID: 106
	F6,
	// Token: 0x0400006B RID: 107
	F7,
	// Token: 0x0400006C RID: 108
	F8,
	// Token: 0x0400006D RID: 109
	F9,
	// Token: 0x0400006E RID: 110
	F10,
	// Token: 0x0400006F RID: 111
	F11,
	// Token: 0x04000070 RID: 112
	F12,
	// Token: 0x04000071 RID: 113
	F13,
	// Token: 0x04000072 RID: 114
	F14,
	// Token: 0x04000073 RID: 115
	F15,
	// Token: 0x04000074 RID: 116
	F16,
	// Token: 0x04000075 RID: 117
	F17,
	// Token: 0x04000076 RID: 118
	F18,
	// Token: 0x04000077 RID: 119
	F19,
	// Token: 0x04000078 RID: 120
	F20,
	// Token: 0x04000079 RID: 121
	F21,
	// Token: 0x0400007A RID: 122
	F22,
	// Token: 0x0400007B RID: 123
	F23,
	// Token: 0x0400007C RID: 124
	F24,
	// Token: 0x0400007D RID: 125
	NumLock = 144,
	// Token: 0x0400007E RID: 126
	ScrollLock,
	// Token: 0x0400007F RID: 127
	NEC_Equal,
	// Token: 0x04000080 RID: 128
	Fujitsu_Jisho = 146,
	// Token: 0x04000081 RID: 129
	Fujitsu_Masshou,
	// Token: 0x04000082 RID: 130
	Fujitsu_Touroku,
	// Token: 0x04000083 RID: 131
	Fujitsu_Loya,
	// Token: 0x04000084 RID: 132
	Fujitsu_Roya,
	// Token: 0x04000085 RID: 133
	LeftShift = 160,
	// Token: 0x04000086 RID: 134
	RightShift,
	// Token: 0x04000087 RID: 135
	LeftControl,
	// Token: 0x04000088 RID: 136
	RightControl,
	// Token: 0x04000089 RID: 137
	LeftMenu,
	// Token: 0x0400008A RID: 138
	RightMenu,
	// Token: 0x0400008B RID: 139
	BrowserBack,
	// Token: 0x0400008C RID: 140
	BrowserForward,
	// Token: 0x0400008D RID: 141
	BrowserRefresh,
	// Token: 0x0400008E RID: 142
	BrowserStop,
	// Token: 0x0400008F RID: 143
	BrowserSearch,
	// Token: 0x04000090 RID: 144
	BrowserFavorites,
	// Token: 0x04000091 RID: 145
	BrowserHome,
	// Token: 0x04000092 RID: 146
	VolumeMute,
	// Token: 0x04000093 RID: 147
	VolumeDown,
	// Token: 0x04000094 RID: 148
	VolumeUp,
	// Token: 0x04000095 RID: 149
	MediaNextTrack,
	// Token: 0x04000096 RID: 150
	MediaPrevTrack,
	// Token: 0x04000097 RID: 151
	MediaStop,
	// Token: 0x04000098 RID: 152
	MediaPlayPause,
	// Token: 0x04000099 RID: 153
	LaunchMail,
	// Token: 0x0400009A RID: 154
	LaunchMediaSelect,
	// Token: 0x0400009B RID: 155
	LaunchApplication1,
	// Token: 0x0400009C RID: 156
	LaunchApplication2,
	// Token: 0x0400009D RID: 157
	OEM1 = 186,
	// Token: 0x0400009E RID: 158
	OEMPlus,
	// Token: 0x0400009F RID: 159
	OEMComma,
	// Token: 0x040000A0 RID: 160
	OEMMinus,
	// Token: 0x040000A1 RID: 161
	OEMPeriod,
	// Token: 0x040000A2 RID: 162
	OEM2,
	// Token: 0x040000A3 RID: 163
	OEM3,
	// Token: 0x040000A4 RID: 164
	OEM4 = 219,
	// Token: 0x040000A5 RID: 165
	OEM5,
	// Token: 0x040000A6 RID: 166
	OEM6,
	// Token: 0x040000A7 RID: 167
	OEM7,
	// Token: 0x040000A8 RID: 168
	OEM8,
	// Token: 0x040000A9 RID: 169
	OEMAX = 225,
	// Token: 0x040000AA RID: 170
	OEM102,
	// Token: 0x040000AB RID: 171
	ICOHelp,
	// Token: 0x040000AC RID: 172
	ICO00,
	// Token: 0x040000AD RID: 173
	ProcessKey,
	// Token: 0x040000AE RID: 174
	ICOClear,
	// Token: 0x040000AF RID: 175
	Packet,
	// Token: 0x040000B0 RID: 176
	OEMReset = 233,
	// Token: 0x040000B1 RID: 177
	OEMJump,
	// Token: 0x040000B2 RID: 178
	OEMPA1,
	// Token: 0x040000B3 RID: 179
	OEMPA2,
	// Token: 0x040000B4 RID: 180
	OEMPA3,
	// Token: 0x040000B5 RID: 181
	OEMWSCtrl,
	// Token: 0x040000B6 RID: 182
	OEMCUSel,
	// Token: 0x040000B7 RID: 183
	OEMATTN,
	// Token: 0x040000B8 RID: 184
	OEMFinish,
	// Token: 0x040000B9 RID: 185
	OEMCopy,
	// Token: 0x040000BA RID: 186
	OEMAuto,
	// Token: 0x040000BB RID: 187
	OEMENLW,
	// Token: 0x040000BC RID: 188
	OEMBackTab,
	// Token: 0x040000BD RID: 189
	ATTN,
	// Token: 0x040000BE RID: 190
	CRSel,
	// Token: 0x040000BF RID: 191
	EXSel,
	// Token: 0x040000C0 RID: 192
	EREOF,
	// Token: 0x040000C1 RID: 193
	Play,
	// Token: 0x040000C2 RID: 194
	Zoom,
	// Token: 0x040000C3 RID: 195
	Noname,
	// Token: 0x040000C4 RID: 196
	PA1,
	// Token: 0x040000C5 RID: 197
	OEMClear
}
