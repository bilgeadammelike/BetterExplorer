﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BExplorer.Shell.Interop {
	/// <summary>
	/// The STGM constants are flags that indicate 
	/// conditions for creating and deleting the object and access modes 
	/// for the object. 
	/// 
	/// You can combine these flags, but you can only choose one flag 
	/// from each group of related flags. Typically one flag from each 
	/// of the access and sharing groups must be specified for all 
	/// functions and methods which use these constants. 
	/// </summary>
	[Flags]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Justification = "Follows native api.")]
	public enum AccessModes {
		/// <summary>
		/// Indicates that, in direct mode, each change to a storage 
		/// or stream element is written as it occurs.
		/// </summary>
		Direct = 0x00000000,

		/// <summary>
		/// Indicates that, in transacted mode, changes are buffered 
		/// and written only if an explicit commit operation is called. 
		/// </summary>
		Transacted = 0x00010000,

		/// <summary>
		/// Provides a faster implementation of a compound file 
		/// in a limited, but frequently used, case. 
		/// </summary>
		Simple = 0x08000000,

		/// <summary>
		/// Indicates that the object is read-only, 
		/// meaning that modifications cannot be made.
		/// </summary>
		Read = 0x00000000,

		/// <summary>
		/// Enables you to save changes to the object, 
		/// but does not permit access to its data. 
		/// </summary>
		Write = 0x00000001,

		/// <summary>
		/// Enables access and modification of object data.
		/// </summary>
		ReadWrite = 0x00000002,

		/// <summary>
		/// Specifies that subsequent openings of the object are 
		/// not denied read or write access. 
		/// </summary>
		ShareDenyNone = 0x00000040,

		/// <summary>
		/// Prevents others from subsequently opening the object in Read mode. 
		/// </summary>
		ShareDenyRead = 0x00000030,

		/// <summary>
		/// Prevents others from subsequently opening the object 
		/// for Write or ReadWrite access.
		/// </summary>
		ShareDenyWrite = 0x00000020,

		/// <summary>
		/// Prevents others from subsequently opening the object in any mode. 
		/// </summary>
		ShareExclusive = 0x00000010,

		/// <summary>
		/// Opens the storage object with exclusive access to the most 
		/// recently committed version.
		/// </summary>
		Priority = 0x00040000,

		/// <summary>
		/// Indicates that the underlying file is to be automatically destroyed when the root 
		/// storage object is released. This feature is most useful for creating temporary files. 
		/// </summary>
		DeleteOnRelease = 0x04000000,

		/// <summary>
		/// Indicates that, in transacted mode, a temporary scratch file is usually used 
		/// to save modifications until the Commit method is called. 
		/// Specifying NoScratch permits the unused portion of the original file 
		/// to be used as work space instead of creating a new file for that purpose. 
		/// </summary>
		NoScratch = 0x00100000,

		/// <summary>
		/// Indicates that an existing storage object 
		/// or stream should be removed before the new object replaces it. 
		/// </summary>
		Create = 0x00001000,

		/// <summary>
		/// Creates the new object while preserving existing data in a stream named "Contents". 
		/// </summary>
		Convert = 0x00020000,

		/// <summary>
		/// Causes the create operation to fail if an existing object with the specified name exists.
		/// </summary>
		FailIfThere = 0x00000000,

		/// <summary>
		/// This flag is used when opening a storage object with Transacted 
		/// and without ShareExclusive or ShareDenyWrite. 
		/// In this case, specifying NoSnapshot prevents the system-provided 
		/// implementation from creating a snapshot copy of the file. 
		/// Instead, changes to the file are written to the end of the file. 
		/// </summary>
		NoSnapshot = 0x00200000,

		/// <summary>
		/// Supports direct mode for single-writer, multireader file operations. 
		/// </summary>
		DirectSingleWriterMultipleReader = 0x00400000
	};



	#region Shell Library Enums

	internal enum LibraryFolderFilter {
		ForceFileSystem = 1,
		StorageItems = 2,
		AllItems = 3
	};

	[Flags]
	internal enum LibraryOptions {
		Default = 0,
		PinnedToNavigationPane = 0x1,
		MaskAll = 0x1
	};

	internal enum DefaultSaveFolderType {
		Detect = 1,
		Private = 2,
		Public = 3
	};

	internal enum LibrarySaveOptions {
		FailIfThere = 0,
		OverrideExisting = 1,
		MakeUniqueName = 2
	};

	internal enum LibraryManageDialogOptions {
		Default = 0,
		NonIndexableLocationWarning = 1
	};

	public enum LibraryFolderType {
		/// <summary>
		/// General Items
		/// </summary>
		Generic = 0,

		/// <summary>
		/// Documents
		/// </summary>
		Documents,

		/// <summary>
		/// Music
		/// </summary>
		Music,

		/// <summary>
		/// Pictures
		/// </summary>
		Pictures,

		/// <summary>
		/// Videos
		/// </summary>
		Videos

	}

	#endregion


	public enum PerceivedType {
		Application = 8,
		Audio = 3,
		Compressed = 5,
		Contacts = 10,
		Custom = -3,
		Document = 6,
		Folder = -1,
		GameMedia = 9,
		Image = 2,
		System = 7,
		Text = 1,
		Unknown = 0,
		Unspecified = -2,
		Video = 4,
	}
	public enum LVBKIF : int {

		SOURCE_NONE = 0x00000000,

		SOURCE_HBITMAP = 0x00000001,

		SOURCE_URL = 0x00000002,

		SOURCE_MASK = 0x00000003,

		STYLE_NORMAL = 0x00000000,

		STYLE_TILE = 0x00000010,

		STYLE_MASK = 0x00000010,

		FLAG_TILEOFFSET = 0x00000100,

		STYLE_WATERMARK = 0x10000000,

		FLAG_ALPHABLEND = 0x20000000

	}

	public struct LVBKIMAGE {

		public LVBKIF ulFlags;

		public IntPtr hbm;

		public IntPtr pszImage;

		public uint cchImageMax;

		public int xOffsetPercent;

		public int yOffsetPercent;

	};
	public struct PROPERTYKEY {
		public Guid fmtid;
		public int pid;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct REFPROPERTYKEY {
		public Guid fmtid;
		public int pid;
	}

	[Flags]
	public enum SIIGBF {
		ResizeToFit = 0x00,
		BiggerSizeOk = 0x01,
		MemoryOnly = 0x02,
		IconOnly = 0x04,
		ThumbnailOnly = 0x08,
		InCacheOnly = 0x10,
	}

	public struct Size {

		public int Height { get; set; }
		public int Width { get; set; }
	}

	[Flags]
	public enum ThumbnailOptions {
		Extract = 0x00000000,
		InCacheOnly = 0x00000001,
		FastExtract = 0x00000002,
		ForceExtraction = 0x00000004,
		SlowReclaim = 0x00000008,
		ExtractDoNotCache = 0x00000020
	}
	[Flags]
	public enum WTS_FLAGS : uint {
		WTS_EXTRACT = 0x00000000,
		WTS_INCACHEONLY = 0x00000001,
		WTS_FASTEXTRACT = 0x00000002,
		WTS_FORCEEXTRACTION = 0x00000004,
		WTS_SLOWRECLAIM = 0x00000008,
		WTS_EXTRACTDONOTCACHE = 0x00000020,
		WTS_SCALETOREQUESTEDSIZE = 0x00000040,
		WTS_SKIPFASTEXTRACT = 0x00000080,
		WTS_EXTRACTINPROC = 0x00000100
	}
	[Flags]
	public enum WTS_CACHEFLAGS : uint {
		WTS_DEFAULT = 0x00000000,
		WTS_LOWQUALITY = 0x00000001,
		WTS_CACHED = 0x00000002
	}
	[StructLayout(LayoutKind.Sequential, Size = 16), Serializable]
	public struct WTS_THUMBNAILID {
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
		byte[] rgbKey;
	}
	[Flags]
	public enum ThumbnailCacheOptions {
		Default = 0x00000000,
		LowQuality = 0x00000001,
		Cached = 0x00000002,
	}

	/// <summary>
	/// Thumbnail Alpha Types
	/// </summary>
	public enum ThumbnailAlphaType {
		/// <summary>
		/// Let the system decide.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// No transparency
		/// </summary>
		NoAlphaChannel = 1,

		/// <summary>
		/// Has transparency
		/// </summary>
		HasAlphaChannel = 2,
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	internal struct ThumbnailId {
		[MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 16)]
		byte rgbKey;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct BITMAP {
		public int bmType;
		public int bmWidth;
		public int bmHeight;
		public int bmWidthBytes;
		public ushort bmPlanes;
		public ushort bmBitsPixel;
		public IntPtr bmBits;
	}

	public enum SICHINTF {
		SICHINT_DISPLAY = 0x00000000,
		SICHINT_CANONICAL = 0x10000000,
		SICHINT_TEST_FILESYSPATH_IF_NOT_EQUAL = 0x20000000,
		SICHINT_ALLFIELDS = unchecked((int)0x80000000)
	}

	/// <summary>
	/// Standard Window messages
	/// </summary>
	public enum WM {
		WM_NULL = 0x0000,
		WM_CREATE = 0x0001,
		WM_DESTROY = 0x0002,
		WM_MOVE = 0x0003,
		WM_SIZE = 0x0005,
		WM_ACTIVATE = 0x0006,
		WM_SETFOCUS = 0x0007,
		WM_KILLFOCUS = 0x0008,
		WM_SETVISIBLE = 0x0009,
		WM_ENABLE = 0x000A,
		WM_SETREDRAW = 0x000B,
		WM_SETTEXT = 0x000C,
		WM_GETTEXT = 0x000D,
		WM_GETTEXTLENGTH = 0x000E,
		WM_PAINT = 0x000F,
		WM_CLOSE = 0x0010,
		WM_QUERYENDSESSION = 0x0011,
		WM_QUIT = 0x0012,
		WM_QUERYOPEN = 0x0013,
		WM_ERASEBKGND = 0x0014,
		WM_SYSCOLORCHANGE = 0x0015,
		WM_ENDSESSION = 0x0016,
		WM_SYSTEMERROR = 0x0017,
		WM_SHOWWINDOW = 0x0018,
		WM_CTLCOLOR = 0x0019,
		WM_WININICHANGE = 0x001A,
		WM_SETTINGCHANGE = 0x001A,
		WM_DEVMODECHANGE = 0x001B,
		WM_ACTIVATEAPP = 0x001C,
		WM_FONTCHANGE = 0x001D,
		WM_TIMECHANGE = 0x001E,
		WM_CANCELMODE = 0x001F,
		WM_SETCURSOR = 0x0020,
		WM_MOUSEACTIVATE = 0x0021,
		WM_CHILDACTIVATE = 0x0022,
		WM_QUEUESYNC = 0x0023,
		WM_GETMINMAXINFO = 0x0024,
		WM_PAINTICON = 0x0026,
		WM_ICONERASEBKGND = 0x0027,
		WM_NEXTDLGCTL = 0x0028,
		WM_ALTTABACTIVE = 0x0029,
		WM_SPOOLERSTATUS = 0x002A,
		WM_DRAWITEM = 0x002B,
		WM_MEASUREITEM = 0x002C,
		WM_DELETEITEM = 0x002D,
		WM_VKEYTOITEM = 0x002E,
		WM_CHARTOITEM = 0x002F,
		WM_SETFONT = 0x0030,
		WM_GETFONT = 0x0031,
		WM_SETHOTKEY = 0x0032,
		WM_GETHOTKEY = 0x0033,
		WM_XBUTTONUP = 0x020C,
		//public const uint WM_FILESYSCHANGE        = 0x0034;
		//public const uint WM_ISACTIVEICON         = 0x0035;
		//public const uint WM_QUERYPARKICON        = 0x0036;
		WM_QUERYDRAGICON = 0x0037,
		WM_COMPAREITEM = 0x0039,
		//public const uint WM_TESTING              = 0x003a;
		//public const uint WM_OTHERWINDOWCREATED = 0x003c;
		WM_GETOBJECT = 0x003D,
		//public const uint WM_ACTIVATESHELLWINDOW        = 0x003e;
		WM_COMPACTING = 0x0041,
		WM_COMMNOTIFY = 0x0044,
		WM_WINDOWPOSCHANGING = 0x0046,
		WM_WINDOWPOSCHANGED = 0x0047,
		WM_POWER = 0x0048,
		WM_COPYDATA = 0x004A,
		WM_CANCELJOURNAL = 0x004B,
		WM_NOTIFY = 0x004E,
		WM_INPUTLANGCHANGEREQUEST = 0x0050,
		WM_INPUTLANGCHANGE = 0x0051,
		WM_TCARD = 0x0052,
		WM_HELP = 0x0053,
		WM_USERCHANGED = 0x0054,
		WM_NOTIFYFORMAT = 0x0055,
		WM_CONTEXTMENU = 0x007B,
		WM_STYLECHANGING = 0x007C,
		WM_STYLECHANGED = 0x007D,
		WM_DISPLAYCHANGE = 0x007E,
		WM_GETICON = 0x007F,

		// Non-Client messages
		WM_SETICON = 0x0080,
		WM_NCCREATE = 0x0081,
		WM_NCDESTROY = 0x0082,
		WM_NCCALCSIZE = 0x0083,
		WM_NCHITTEST = 0x0084,
		WM_NCPAINT = 0x0085,
		WM_NCACTIVATE = 0x0086,
		WM_GETDLGCODE = 0x0087,
		WM_SYNCPAINT = 0x0088,
		//public const uint WM_SYNCTASK       = 0x0089;
		WM_NCMOUSEMOVE = 0x00A0,
		WM_NCLBUTTONDOWN = 0x00A1,
		WM_NCLBUTTONUP = 0x00A2,
		WM_NCLBUTTONDBLCLK = 0x00A3,
		WM_NCRBUTTONDOWN = 0x00A4,
		WM_NCRBUTTONUP = 0x00A5,
		WM_NCRBUTTONDBLCLK = 0x00A6,
		WM_NCMBUTTONDOWN = 0x00A7,
		WM_NCMBUTTONUP = 0x00A8,
		WM_NCMBUTTONDBLCLK = 0x00A9,
		//public const uint WM_NCXBUTTONDOWN    = 0x00ab;
		//public const uint WM_NCXBUTTONUP      = 0x00ac;
		//public const uint WM_NCXBUTTONDBLCLK  = 0x00ad;
		WM_KEYDOWN = 0x0100,
		WM_KEYFIRST = 0x0100,
		WM_KEYUP = 0x0101,
		WM_CHAR = 0x0102,
		WM_DEADCHAR = 0x0103,
		WM_SYSKEYDOWN = 0x0104,
		WM_SYSKEYUP = 0x0105,
		WM_SYSCHAR = 0x0106,
		WM_SYSDEADCHAR = 0x0107,
		WM_KEYLAST = 0x0108,
		WM_IME_STARTCOMPOSITION = 0x010D,
		WM_IME_ENDCOMPOSITION = 0x010E,
		WM_IME_COMPOSITION = 0x010F,
		WM_IME_KEYLAST = 0x010F,
		WM_INITDIALOG = 0x0110,
		WM_COMMAND = 0x0111,
		WM_SYSCOMMAND = 0x0112,
		WM_TIMER = 0x0113,
		WM_HSCROLL = 0x0114,
		WM_VSCROLL = 0x0115,
		WM_INITMENU = 0x0116,
		WM_INITMENUPOPUP = 0x0117,
		//public const uint WM_SYSTIMER       = 0x0118;
		WM_MENUSELECT = 0x011F,
		WM_MENUCHAR = 0x0120,
		WM_ENTERIDLE = 0x0121,
		WM_MENURBUTTONUP = 0x0122,
		WM_MENUDRAG = 0x0123,
		WM_MENUGETOBJECT = 0x0124,
		WM_UNINITMENUPOPUP = 0x0125,
		WM_MENUCOMMAND = 0x0126,
		//public const uint WM_CHANGEUISTATE    = 0x0127;
		//public const uint WM_UPDATEUISTATE    = 0x0128;
		//public const uint WM_QUERYUISTATE     = 0x0129;
		//
		//public const uint WM_LBTRACKPOINT     = 0x0131;
		WM_CTLCOLORMSGBOX = 0x0132,
		WM_CTLCOLOREDIT = 0x0133,
		WM_CTLCOLORLISTBOX = 0x0134,
		WM_CTLCOLORBTN = 0x0135,
		WM_CTLCOLORDLG = 0x0136,
		WM_CTLCOLORSCROLLBAR = 0x0137,
		WM_CTLCOLORSTATIC = 0x0138,
		WM_MOUSEMOVE = 0x0200,
		WM_MOUSEFIRST = 0x0200,
		WM_LBUTTONDOWN = 0x0201,
		WM_LBUTTONUP = 0x0202,
		WM_LBUTTONDBLCLK = 0x0203,
		WM_RBUTTONDOWN = 0x0204,
		WM_RBUTTONUP = 0x0205,
		WM_RBUTTONDBLCLK = 0x0206,
		WM_MBUTTONDOWN = 0x0207,
		WM_MBUTTONUP = 0x0208,
		WM_MBUTTONDBLCLK = 0x0209,
		WM_MOUSEWHEEL = 0x020A,
		WM_MOUSELAST = 0x020D,
		//public const uint WM_XBUTTONDOWN      = 0x020B;
		//public const uint WM_XBUTTONUP        = 0x020C;
		//public const uint WM_XBUTTONDBLCLK    = 0x020D;
		WM_PARENTNOTIFY = 0x0210,
		WM_ENTERMENULOOP = 0x0211,
		WM_EXITMENULOOP = 0x0212,
		WM_NEXTMENU = 0x0213,
		WM_SIZING = 0x0214,
		WM_CAPTURECHANGED = 0x0215,
		WM_MOVING = 0x0216,
		WM_POWERBROADCAST = 0x0218,
		WM_DEVICECHANGE = 0x0219,
		WM_MDICREATE = 0x0220,
		WM_MDIDESTROY = 0x0221,
		WM_MDIACTIVATE = 0x0222,
		WM_MDIRESTORE = 0x0223,
		WM_MDINEXT = 0x0224,
		WM_MDIMAXIMIZE = 0x0225,
		WM_MDITILE = 0x0226,
		WM_MDICASCADE = 0x0227,
		WM_MDIICONARRANGE = 0x0228,
		WM_MDIGETACTIVE = 0x0229,
		/* D&D messages */
		//public const uint WM_DROPOBJECT     = 0x022A;
		//public const uint WM_QUERYDROPOBJECT  = 0x022B;
		//public const uint WM_BEGINDRAG      = 0x022C;
		//public const uint WM_DRAGLOOP       = 0x022D;
		//public const uint WM_DRAGSELECT     = 0x022E;
		//public const uint WM_DRAGMOVE       = 0x022F;
		WM_MDISETMENU = 0x0230,
		WM_ENTERSIZEMOVE = 0x0231,
		WM_EXITSIZEMOVE = 0x0232,
		WM_DROPFILES = 0x0233,
		WM_MDIREFRESHMENU = 0x0234,
		WM_IME_SETCONTEXT = 0x0281,
		WM_IME_NOTIFY = 0x0282,
		WM_IME_CONTROL = 0x0283,
		WM_IME_COMPOSITIONFULL = 0x0284,
		WM_IME_SELECT = 0x0285,
		WM_IME_CHAR = 0x0286,
		WM_IME_REQUEST = 0x0288,
		WM_IME_KEYDOWN = 0x0290,
		WM_IME_KEYUP = 0x0291,
		WM_MOUSEHOVER = 0x02A1,
		WM_MOUSELEAVE = 0x02A3,
		WM_CUT = 0x0300,
		WM_COPY = 0x0301,
		WM_PASTE = 0x0302,
		WM_CLEAR = 0x0303,
		WM_UNDO = 0x0304,
		WM_RENDERFORMAT = 0x0305,
		WM_RENDERALLFORMATS = 0x0306,
		WM_DESTROYCLIPBOARD = 0x0307,
		WM_DRAWCLIPBOARD = 0x0308,
		WM_PAINTCLIPBOARD = 0x0309,
		WM_VSCROLLCLIPBOARD = 0x030A,
		WM_SIZECLIPBOARD = 0x030B,
		WM_ASKCBFORMATNAME = 0x030C,
		WM_CHANGECBCHAIN = 0x030D,
		WM_HSCROLLCLIPBOARD = 0x030E,
		WM_QUERYNEWPALETTE = 0x030F,
		WM_PALETTEISCHANGING = 0x0310,
		WM_PALETTECHANGED = 0x0311,
		WM_HOTKEY = 0x0312,
		WM_PRINT = 0x0317,
		WM_PRINTCLIENT = 0x0318,
		WM_HANDHELDFIRST = 0x0358,
		WM_HANDHELDLAST = 0x035F,
		WM_AFXFIRST = 0x0360,
		WM_AFXLAST = 0x037F,
		WM_PENWINFIRST = 0x0380,
		WM_PENWINLAST = 0x038F,
		WM_APP = 0x8000,
		WM_USER = 0x0400,

		// Our "private" ones
		WM_MOUSE_ENTER = 0x0401,
		WM_MOUSE_LEAVE = 0x0402,
		WM_ASYNC_MESSAGE = 0x0403,
		WM_REFLECT = WM_USER + 0x1c00
	}

	public enum HDN {
		HDN_FIRST = -300,
		HDN_LAST = -399,
		HDN_ITEMCHANGINGA = (HDN_FIRST - 0),
		HDN_ITEMCHANGINGW = (HDN_FIRST - 20),
		HDN_ITEMCHANGEDA = (HDN_FIRST - 1),
		HDN_ITEMCHANGEDW = (HDN_FIRST - 21),
		HDN_ITEMCLICKA = (HDN_FIRST - 2),
		HDN_ITEMCLICKW = (HDN_FIRST - 22),
		HDN_ITEMDBLCLICKA = (HDN_FIRST - 3),
		HDN_ITEMDBLCLICKW = (HDN_FIRST - 23),
		HDN_DIVIDERDBLCLICKA = (HDN_FIRST - 5),
		HDN_DIVIDERDBLCLICKW = (HDN_FIRST - 25),
		HDN_BEGINTRACKA = (HDN_FIRST - 6),
		HDN_BEGINTRACKW = (HDN_FIRST - 26),
		HDN_ENDTRACKA = (HDN_FIRST - 7),
		HDN_ENDTRACKW = (HDN_FIRST - 27),
		HDN_TRACKA = (HDN_FIRST - 8),
		HDN_TRACKW = (HDN_FIRST - 28),
		HDN_GETDISPINFOA = (HDN_FIRST - 9),
		HDN_GETDISPINFOW = (HDN_FIRST - 29),
		HDN_BEGINDRAG = (HDN_FIRST - 10),
		HDN_ENDDRAG = (HDN_FIRST - 11),
		HDN_FILTERCHANGE = (HDN_FIRST - 12),
		HDN_FILTERBTNCLICK = (HDN_FIRST - 13),
		HDN_BEGINFILTEREDIT = (HDN_FIRST - 14),
		HDN_ENDFILTEREDIT = (HDN_FIRST - 15),
		HDN_ITEMSTATEICONCLICK = (HDN_FIRST - 16),
		HDN_ITEMKEYDOWN = (HDN_FIRST - 17),
		HDN_DROPDOWN = (HDN_FIRST - 18),
		HDN_OVERFLOWCLICK = (HDN_FIRST - 19),
	}

	public enum LVNI {
		LVNI_ALL = 0x0000,
		LVNI_FOCUSED = 0x0001,
		LVNI_SELECTED = 0x0002,
		LVNI_CUT = 0x0004,
		LVNI_DROPHILITED = 0x0008,
		LVNI_STATEMASK = (LVNI_FOCUSED | LVNI_SELECTED | LVNI_CUT | LVNI_DROPHILITED),
	}

	public enum ListViewExtendedStyles {
		LVS_EX_AUTOAUTOARRANGE = 0x1000000,
		/// <summary>
		/// LVS_EX_GRIDLINES
		/// </summary>
		GridLines = 0x00000001,
		/// <summary>
		/// LVS_EX_SUBITEMIMAGES
		/// </summary>
		SubItemImages = 0x00000002,
		/// <summary>
		/// LVS_EX_CHECKBOXES
		/// </summary>
		CheckBoxes = 0x00000004,
		LVS_EX_AUTOCHECKSELECT = 0x8000000,
		/// <summary>
		/// LVS_EX_TRACKSELECT
		/// </summary>
		TrackSelect = 0x00000008,
		/// <summary>
		/// LVS_EX_HEADERDRAGDROP
		/// </summary>
		HeaderDragDrop = 0x00000010,
		/// <summary>
		/// LVS_EX_FULLROWSELECT
		/// </summary>
		FullRowSelect = 0x00000020,
		/// <summary>
		/// LVS_EX_ONECLICKACTIVATE
		/// </summary>
		OneClickActivate = 0x00000040,
		/// <summary>
		/// LVS_EX_TWOCLICKACTIVATE
		/// </summary>
		TwoClickActivate = 0x00000080,
		/// <summary>
		/// LVS_EX_FLATSB
		/// </summary>
		FlatsB = 0x00000100,
		/// <summary>
		/// LVS_EX_REGIONAL
		/// </summary>
		Regional = 0x00000200,
		/// <summary>
		/// LVS_EX_INFOTIP
		/// </summary>
		InfoTip = 0x00000400,
		/// <summary>
		/// LVS_EX_UNDERLINEHOT
		/// </summary>
		UnderlineHot = 0x00000800,
		/// <summary>
		/// LVS_EX_UNDERLINECOLD
		/// </summary>
		UnderlineCold = 0x00001000,
		/// <summary>
		/// LVS_EX_MULTIWORKAREAS
		/// </summary>
		MultilWorkAreas = 0x00002000,
		/// <summary>
		/// LVS_EX_LABELTIP
		/// </summary>
		LabelTip = 0x00004000,
		/// <summary>
		/// LVS_EX_BORDERSELECT
		/// </summary>
		BorderSelect = 0x00008000,
		/// <summary>
		/// LVS_EX_DOUBLEBUFFER
		/// </summary>
		DoubleBuffer = 0x00010000,
		/// <summary>
		/// LVS_EX_HIDELABELS
		/// </summary>
		HideLabels = 0x00020000,
		/// <summary>
		/// LVS_EX_SINGLEROW
		/// </summary>
		SingleRow = 0x00040000,
		/// <summary>
		/// LVS_EX_SNAPTOGRID
		/// </summary>
		SnapToGrid = 0x00080000,
		/// <summary>
		/// LVS_EX_SIMPLESELECT
		/// </summary>
		SimpleSelect = 0x00100000,
		/// <summary>
		/// LVS_EX_AUTOSIZECOLUMNS
		/// </summary>
		AutosizeColumns = 0x10000000,
		/// <summary>
		/// LVS_EX_HEADERINALLVIEWS
		/// </summary>
		HeaderInAllViews = 0x2000000,
		LVS_EX_DOUBLEBUFFER = 0x00010000,
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct POINT {
		public int x;
		public int y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct LVITEMINDEX {
		public int iItem;
		public int iGroup;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct LVHITTESTINFO {
		public POINT pt;
		public uint flags;
		public int iItem;
		public int iSubItem;
	}
}
