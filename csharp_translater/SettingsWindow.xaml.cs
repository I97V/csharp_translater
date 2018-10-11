using System;
using System.Windows;

namespace csharp_translater
{
	public partial class SettingsWindow : Window
	{
		public SettingsWindow()
		{
			InitializeComponent();

			BuildBoxes();
		}

		private void BuildBoxes()
		{
			/*		RUSSIAN			*/
			FillBoxes_rus_A();
			FillBoxes_rus_a();

			FillBoxes_rus_B();
			FillBoxes_rus_b();

			FillBoxes_rus_V();
			FillBoxes_rus_v();

			/*FillBoxes_rus_G();
			FillBoxes_rus_g();

			FillBoxes_rus_D();
			FillBoxes_rus_d();

			FillBoxes_rus_E();
			FillBoxes_rus_e();

			FillBoxes_rus_YO();
			FillBoxes_rus_yo();

			FillBoxes_rus_ZH();
			FillBoxes_rus_zh();

			FillBoxes_rus_Z();
			FillBoxes_rus_z();

			FillBoxes_rus_I();
			FillBoxes_rus_i();

			FillBoxes_rus_IK();
			FillBoxes_rus_ik();

			FillBoxes_rus_K();
			FillBoxes_rus_k();

			FillBoxes_rus_L();
			FillBoxes_rus_l();

			FillBoxes_rus_M();
			FillBoxes_rus_m();

			FillBoxes_rus_N();
			FillBoxes_rus_n();

			FillBoxes_rus_O();
			FillBoxes_rus_o();

			FillBoxes_rus_P();
			FillBoxes_rus_p();

			FillBoxes_rus_R();
			FillBoxes_rus_r();

			FillBoxes_rus_S();
			FillBoxes_rus_s();

			FillBoxes_rus_T();
			FillBoxes_rus_t();

			FillBoxes_rus_IU();
			FillBoxes_rus_iu();

			FillBoxes_rus_F();
			FillBoxes_rus_f();

			FillBoxes_rus_H();
			FillBoxes_rus_h();

			FillBoxes_rus_C();
			FillBoxes_rus_c();

			FillBoxes_rus_CH();
			FillBoxes_rus_ch();

			FillBoxes_rus_SHA();
			FillBoxes_rus_sha();

			FillBoxes_rus_SHU();
			FillBoxes_rus_SHU();

			FillBoxes_rus_TZNAK();
			FillBoxes_rus_tznak();

			FillBoxes_rus_bl_b();
			FillBoxes_rus_bl_s();

			FillBoxes_rus_MZNAK();
			FillBoxes_rus_mznak();

			FillBoxes_rus_AA();
			FillBoxes_rus_aa();

			FillBoxes_rus_U();
			FillBoxes_rus_u();

			FillBoxes_rus_IA();
			FillBoxes_rus_IA();

			/*		ENGLISH			*/
			/*FillBoxes_eng_A();
			FillBoxes_eng_a();

			FillBoxes_eng_B();
			FillBoxes_eng_b();

			FillBoxes_eng_C();
			FillBoxes_eng_c();

			FillBoxes_eng_D();
			FillBoxes_eng_d();

			FillBoxes_eng_E();
			FillBoxes_eng_e();

			FillBoxes_eng_F();
			FillBoxes_eng_f();

			FillBoxes_eng_G();
			FillBoxes_eng_g();

			FillBoxes_eng_H();
			FillBoxes_eng_h();

			FillBoxes_eng_I();
			FillBoxes_eng_i();

			FillBoxes_eng_J();
			FillBoxes_eng_j();

			FillBoxes_eng_K();
			FillBoxes_eng_k();

			FillBoxes_eng_L();
			FillBoxes_eng_l();

			FillBoxes_eng_M();
			FillBoxes_eng_m();

			FillBoxes_eng_N();
			FillBoxes_eng_n();

			FillBoxes_eng_O();
			FillBoxes_eng_o();

			FillBoxes_eng_P();
			FillBoxes_eng_p();

			FillBoxes_eng_Q();
			FillBoxes_eng_q();

			FillBoxes_eng_R();
			FillBoxes_eng_r();

			FillBoxes_eng_S();
			FillBoxes_eng_s();

			FillBoxes_eng_T();
			FillBoxes_eng_t();

			FillBoxes_eng_U();
			FillBoxes_eng_u();

			FillBoxes_eng_V();
			FillBoxes_eng_v();

			FillBoxes_eng_W();
			FillBoxes_eng_w();

			FillBoxes_eng_X();
			FillBoxes_eng_x();

			FillBoxes_eng_Y();
			FillBoxes_eng_y();

			FillBoxes_eng_Z();
			FillBoxes_eng_z();*/
		}

		private void pattern()
		{
			cb_rus_A.Items.Add(Convert.ToChar(000));         // 0
			cb_rus_A.Items.Add(Convert.ToChar(000));         // 1
			cb_rus_A.Items.Add(Convert.ToChar(000));         // 2
			cb_rus_A.Items.Add(Convert.ToChar(000));         // 3
			cb_rus_A.Items.Add(Convert.ToChar(000));         // 4
			cb_rus_A.Items.Add(Convert.ToChar(000));         // 5
			cb_rus_A.Items.Add(Convert.ToChar(000));         // 6
			cb_rus_A.Items.Add(Convert.ToChar(000));         // 7
			cb_rus_A.Items.Add(Convert.ToChar(000));         // 8
			cb_rus_A.Items.Add(Convert.ToChar(000));         // 9

			// 65		A
		}

		/*	А	*/
		private void FillBoxes_rus_A()
		{
			cb_rus_A.Items.Add(Convert.ToChar(65));			// 0
			cb_rus_A.Items.Add(Convert.ToChar(192));        // 1
			cb_rus_A.Items.Add(Convert.ToChar(193));		// 2
			cb_rus_A.Items.Add(Convert.ToChar(194));        // 3
			cb_rus_A.Items.Add(Convert.ToChar(195));        // 4
			cb_rus_A.Items.Add(Convert.ToChar(196));        // 5
			cb_rus_A.Items.Add(Convert.ToChar(197));        // 6
			cb_rus_A.Items.Add(Convert.ToChar(256));        // 7
			cb_rus_A.Items.Add(Convert.ToChar(258));        // 8
			cb_rus_A.Items.Add(Convert.ToChar(260));        // 9
			cb_rus_A.Items.Add(Convert.ToChar(478));        // 10
			cb_rus_A.Items.Add(Convert.ToChar(479));        // 11
			cb_rus_A.Items.Add(Convert.ToChar(480));        // 12
			cb_rus_A.Items.Add(Convert.ToChar(506));        // 13
			cb_rus_A.Items.Add(Convert.ToChar(512));        // 14
			cb_rus_A.Items.Add(Convert.ToChar(514));        // 15
			cb_rus_A.Items.Add(Convert.ToChar(550));        // 16
			cb_rus_A.Items.Add(Convert.ToChar(570));        // 17
			cb_rus_A.Items.Add(Convert.ToChar(1040));       // 18
			cb_rus_A.Items.Add(Convert.ToChar(1232));       // 19
			cb_rus_A.Items.Add(Convert.ToChar(1234));       // 20
			cb_rus_A.Items.Add(Convert.ToChar(5034));       // 21
			cb_rus_A.Items.Add(Convert.ToChar(5573));       // 22
			cb_rus_A.Items.Add(Convert.ToChar(5579));       // 23
			cb_rus_A.Items.Add(Convert.ToChar(5591));       // 24
			cb_rus_A.Items.Add(Convert.ToChar(7680));       // 25
			cb_rus_A.Items.Add(Convert.ToChar(7840));       // 26
			cb_rus_A.Items.Add(Convert.ToChar(7842));       // 27
			cb_rus_A.Items.Add(Convert.ToChar(7844));       // 28
			cb_rus_A.Items.Add(Convert.ToChar(7846));       // 29
			cb_rus_A.Items.Add(Convert.ToChar(7848));       // 30
			cb_rus_A.Items.Add(Convert.ToChar(7850));       // 31
			cb_rus_A.Items.Add(Convert.ToChar(7852));       // 32
			cb_rus_A.Items.Add(Convert.ToChar(7854));       // 33
			cb_rus_A.Items.Add(Convert.ToChar(7856));       // 34
			cb_rus_A.Items.Add(Convert.ToChar(7858));       // 35
			cb_rus_A.Items.Add(Convert.ToChar(7860));       // 36
			cb_rus_A.Items.Add(Convert.ToChar(7862));       // 37
			cb_rus_A.Items.Add(Convert.ToChar(7944));       // 38
			cb_rus_A.Items.Add(Convert.ToChar(7945));       // 39
			cb_rus_A.Items.Add(Convert.ToChar(7946));       // 40
			cb_rus_A.Items.Add(Convert.ToChar(7947));       // 41
			cb_rus_A.Items.Add(Convert.ToChar(7948));       // 42
			cb_rus_A.Items.Add(Convert.ToChar(7949));       // 43
			cb_rus_A.Items.Add(Convert.ToChar(7950));       // 44
			cb_rus_A.Items.Add(Convert.ToChar(7951));       // 45
			cb_rus_A.Items.Add(Convert.ToChar(8072));       // 46
			cb_rus_A.Items.Add(Convert.ToChar(8073));       // 47
			cb_rus_A.Items.Add(Convert.ToChar(8074));       // 48
			cb_rus_A.Items.Add(Convert.ToChar(8075));       // 49
			cb_rus_A.Items.Add(Convert.ToChar(8076));       // 50
			cb_rus_A.Items.Add(Convert.ToChar(8077));       // 51
			cb_rus_A.Items.Add(Convert.ToChar(8078));       // 52
			cb_rus_A.Items.Add(Convert.ToChar(8079));       // 53
			cb_rus_A.Items.Add(Convert.ToChar(8120));       // 54
			cb_rus_A.Items.Add(Convert.ToChar(8121));       // 55
			cb_rus_A.Items.Add(Convert.ToChar(8122));       // 56
			cb_rus_A.Items.Add(Convert.ToChar(8123));       // 57
			cb_rus_A.Items.Add(Convert.ToChar(8124));       // 58
			cb_rus_A.Items.Add(Convert.ToChar(8371));       // 59
			cb_rus_A.Items.Add(Convert.ToChar(12580));      // 60
			cb_rus_A.Items.Add(Convert.ToChar(42222));      // 61
			cb_rus_A.Items.Add(Convert.ToChar(43777));      // 62
			cb_rus_A.Items.Add(Convert.ToChar(43778));      // 63
			cb_rus_A.Items.Add(Convert.ToChar(43779));      // 64
			cb_rus_A.Items.Add(Convert.ToChar(43780));      // 65
			cb_rus_A.Items.Add(Convert.ToChar(43781));      // 66
			cb_rus_A.Items.Add(Convert.ToChar(43782));      // 67
			cb_rus_A.Items.Add(Convert.ToChar(5068));       // 68
			cb_rus_A.Items.Add(Convert.ToChar(7424));       // 69
			cb_rus_A.Items.Add(Convert.ToChar(42223));       // 70


			// 65		A
			// 192		À
			// 193		Á
			// 194		Â
			// 195		Ã
			// 196		Ä
			// 197		Å
			// 256		Ā
			// 258		Ă
			// 260		Ą
			// 478		Ǟ
			// 479		ǟ
			// 480		Ǡ
			// 506		Ǻ
			// 512		Ȁ
			// 514		Ȃ
			// 550		Ȧ
			// 570		Ⱥ
			// 1040		А
			// 1232		Ӑ
			// 1234		Ӓ
			// 5034		Ꭺ
			// 5573		ᗅ
			// 5579		ᗋ
			// 5591		ᗗ
			// 7680		Ḁ
			// 7840		Ạ
			// 7842		Ả
			// 7844		Ấ
			// 7846		Ầ
			// 7848		Ẩ
			// 7850		Ẫ
			// 7852		Ậ
			// 7854		Ắ
			// 7856		Ằ
			// 7858		Ẳ
			// 7860		Ẵ
			// 7862		Ặ
			// 7944		   Ἀ
			// 7945        Ἁ
			// 7946        Ἂ
			// 7947        Ἃ
			// 7948        Ἄ
			// 7949        Ἅ
			// 7950        Ἆ
			// 7951        Ἇ
			// 8072        ᾈ
			// 8073        ᾉ
			// 8074        ᾊ
			// 8075        ᾋ
			// 8076        ᾌ
			// 8077        ᾍ
			// 8078        ᾎ
			// 8079        ᾏ
			// 8120        Ᾰ
			// 8121        Ᾱ
			// 8122        Ὰ
			// 8123        Ά
			// 8124        ᾼ
			// 8371        ₳
			// 12580	   ㄤ
			// 42222	   ꓮ
			// 43777       ꬁ
			// 43778       ꬂ
			// 43779       ꬃ
			// 43780       ꬄ
			// 43781       ꬅ
			// 43782       ꬆ

			// 5068        Ꮜ
			// 7424        ᴀ
			// 42223		ꓯ
		}

		private void FillBoxes_rus_a()
		{
			cb_rus_a.Items.Add(Convert.ToChar(64));         // 0
			cb_rus_a.Items.Add(Convert.ToChar(97));         // 1
			cb_rus_a.Items.Add(Convert.ToChar(224));         // 2
			cb_rus_a.Items.Add(Convert.ToChar(225));         // 3
			cb_rus_a.Items.Add(Convert.ToChar(226));         // 4
			cb_rus_a.Items.Add(Convert.ToChar(227));         // 5
			cb_rus_a.Items.Add(Convert.ToChar(228));         // 6
			cb_rus_a.Items.Add(Convert.ToChar(229));         // 7
			cb_rus_a.Items.Add(Convert.ToChar(257));         // 8
			cb_rus_a.Items.Add(Convert.ToChar(259));         // 9
			cb_rus_a.Items.Add(Convert.ToChar(261));         // 10
			cb_rus_a.Items.Add(Convert.ToChar(462));         // 11
			cb_rus_a.Items.Add(Convert.ToChar(479));         // 12
			cb_rus_a.Items.Add(Convert.ToChar(481));         // 13
			cb_rus_a.Items.Add(Convert.ToChar(513));         // 14
			cb_rus_a.Items.Add(Convert.ToChar(515));         // 15
			cb_rus_a.Items.Add(Convert.ToChar(551));         // 16
			cb_rus_a.Items.Add(Convert.ToChar(592));         // 17
			cb_rus_a.Items.Add(Convert.ToChar(593));         // 18
			cb_rus_a.Items.Add(Convert.ToChar(594));         // 19
			cb_rus_a.Items.Add(Convert.ToChar(867));         // 20
			cb_rus_a.Items.Add(Convert.ToChar(940));         // 21
			cb_rus_a.Items.Add(Convert.ToChar(945));         // 22
			cb_rus_a.Items.Add(Convert.ToChar(1072));         // 23
			cb_rus_a.Items.Add(Convert.ToChar(1233));         // 24
			cb_rus_a.Items.Add(Convert.ToChar(1235));         // 25
			cb_rus_a.Items.Add(Convert.ToChar(1382));         // 26
			cb_rus_a.Items.Add(Convert.ToChar(7468));         // 27
			cb_rus_a.Items.Add(Convert.ToChar(7491));         // 28
			cb_rus_a.Items.Add(Convert.ToChar(7681));         // 29
			cb_rus_a.Items.Add(Convert.ToChar(7834));         // 30
			cb_rus_a.Items.Add(Convert.ToChar(7841));         // 31
			cb_rus_a.Items.Add(Convert.ToChar(7843));         // 32
			cb_rus_a.Items.Add(Convert.ToChar(7845));         // 33
			cb_rus_a.Items.Add(Convert.ToChar(7847));         // 34
			cb_rus_a.Items.Add(Convert.ToChar(7849));         // 35
			cb_rus_a.Items.Add(Convert.ToChar(7851));         // 36
			cb_rus_a.Items.Add(Convert.ToChar(7853));         // 37
			cb_rus_a.Items.Add(Convert.ToChar(7855));         // 38
			cb_rus_a.Items.Add(Convert.ToChar(7857));         // 39
			cb_rus_a.Items.Add(Convert.ToChar(7859));         // 40
			cb_rus_a.Items.Add(Convert.ToChar(7861));         // 41
			cb_rus_a.Items.Add(Convert.ToChar(7863));         // 42
			cb_rus_a.Items.Add(Convert.ToChar(7936));         // 43
			cb_rus_a.Items.Add(Convert.ToChar(7937));         // 44
			cb_rus_a.Items.Add(Convert.ToChar(7938));         // 45
			cb_rus_a.Items.Add(Convert.ToChar(7939));         // 46
			cb_rus_a.Items.Add(Convert.ToChar(7940));         // 47
			cb_rus_a.Items.Add(Convert.ToChar(7941));         // 48
			cb_rus_a.Items.Add(Convert.ToChar(7942));         // 49
			cb_rus_a.Items.Add(Convert.ToChar(7943));         // 50
			cb_rus_a.Items.Add(Convert.ToChar(8048));         // 51
			cb_rus_a.Items.Add(Convert.ToChar(8049));         // 51
			cb_rus_a.Items.Add(Convert.ToChar(8064));         // 52
			cb_rus_a.Items.Add(Convert.ToChar(8065));         // 53
			cb_rus_a.Items.Add(Convert.ToChar(8066));         // 54
			cb_rus_a.Items.Add(Convert.ToChar(8067));         // 55
			cb_rus_a.Items.Add(Convert.ToChar(8068));         // 56
			cb_rus_a.Items.Add(Convert.ToChar(8069));         // 57
			cb_rus_a.Items.Add(Convert.ToChar(8070));         // 58
			cb_rus_a.Items.Add(Convert.ToChar(8071));         // 59
			cb_rus_a.Items.Add(Convert.ToChar(8112));         // 60
			cb_rus_a.Items.Add(Convert.ToChar(8113));         // 61
			cb_rus_a.Items.Add(Convert.ToChar(8114));         // 62
			cb_rus_a.Items.Add(Convert.ToChar(8115));         // 63
			cb_rus_a.Items.Add(Convert.ToChar(8116));         // 64
			cb_rus_a.Items.Add(Convert.ToChar(8118));         // 65
			cb_rus_a.Items.Add(Convert.ToChar(8119));         // 66
			cb_rus_a.Items.Add(Convert.ToChar(8336));         // 67

			// 64		@
			// 97		a
			// 224     à
			// 225     á
			// 226     â
			// 227     ã
			// 228     ä
			// 229     å
			// 257		ā
			// 259		ă
			// 261		ą
			// 462		ǎ
			// 479		ǟ
			// 481		ǡ
			// 513		ȁ
			// 515		ȃ
			// 551		ȧ
			// 592		ɐ
			// 593		ɑ
			// 594		ɒ
			// 867		ͣ
			// 940		ά
			// 945		α
			// 1072		а
			// 1233		ӑ
			// 1235		ӓ
			// 1382		զ
			// 7468		ᴬ
			// 7491		ᵃ
			// 7681		ḁ
			// 7834		ẚ
			// 7841        ạ
			// 7843        ả
			// 7845        ấ
			// 7847        ầ
			// 7849        ẩ
			// 7851        ẫ
			// 7853        ậ
			// 7855        ắ
			// 7857        ằ
			// 7859        ẳ
			// 7861        ẵ
			// 7863        ặ
			// 7936        ἀ
			// 7937        ἁ
			// 7938        ἂ
			// 7939        ἃ
			// 7940        ἄ
			// 7941        ἅ
			// 7942        ἆ
			// 7943        ἇ
			// 8048        ὰ
			// 8049        ά
			// 8064        ᾀ
			// 8065        ᾁ
			// 8066        ᾂ
			// 8067        ᾃ
			// 8068        ᾄ
			// 8069        ᾅ
			// 8070        ᾆ
			// 8071        ᾇ
			// 8112        ᾰ
			// 8113        ᾱ
			// 8114        ᾲ
			// 8115        ᾳ
			// 8116        ᾴ
			// 8118        ᾶ
			// 8119        ᾷ
			// 8336		ₐ
		}

		/*	Б	*/
		private void FillBoxes_rus_B()
		{
			cb_rus_B.Items.Add(Convert.ToChar(386));         // 0
			cb_rus_B.Items.Add(Convert.ToChar(387));         // 1
			cb_rus_B.Items.Add(Convert.ToChar(395));         // 2
			cb_rus_B.Items.Add(Convert.ToChar(396));         // 3
			cb_rus_B.Items.Add(Convert.ToChar(1172));         // 4
			cb_rus_B.Items.Add(Convert.ToChar(2990));         // 5
			cb_rus_B.Items.Add(Convert.ToChar(19970));         // 6
			cb_rus_B.Items.Add(Convert.ToChar(19975));         // 7
			cb_rus_B.Items.Add(Convert.ToChar(43074));         // 8

			// 386     Ƃ
			// 387     ƃ
			// 395     Ƌ
			// 396     ƌ
			// 1172		Ҕ
			// 2990		ம
			// 19970		丂
			// 19975		万
			// 43074		ꡂ
		}

		private void FillBoxes_rus_b()
		{
			cb_rus_b.Items.Add(Convert.ToChar(1004));         // 0
			cb_rus_b.Items.Add(Convert.ToChar(1005));         // 1
			cb_rus_b.Items.Add(Convert.ToChar(1073));         // 2
			cb_rus_b.Items.Add(Convert.ToChar(1173));         // 3
			cb_rus_b.Items.Add(Convert.ToChar(43512));         // 4

			// 1004        Ϭ
			// 1005        ϭ
			// 1073			б
			// 1173        ҕ
			// 43512		꧸
		}

		/*	В	*/
		private void FillBoxes_rus_V()
		{
			cb_rus_V.Items.Add(Convert.ToChar(223));         // 0
			cb_rus_V.Items.Add(Convert.ToChar(579));         // 1
			cb_rus_V.Items.Add(Convert.ToChar(946));         // 2
			cb_rus_V.Items.Add(Convert.ToChar(1042));         // 3
			cb_rus_V.Items.Add(Convert.ToChar(1349));         // 4
			cb_rus_V.Items.Add(Convert.ToChar(3435));         // 5
			cb_rus_V.Items.Add(Convert.ToChar(3647));         // 6
			cb_rus_V.Items.Add(Convert.ToChar(4330));         // 7
			cb_rus_V.Items.Add(Convert.ToChar(5104));         // 8
			cb_rus_V.Items.Add(Convert.ToChar(5108));         // 9
			cb_rus_V.Items.Add(Convert.ToChar(5725));         // 10
			cb_rus_V.Items.Add(Convert.ToChar(5726));         // 11
			cb_rus_V.Items.Add(Convert.ToChar(5727));         // 12
			cb_rus_V.Items.Add(Convert.ToChar(7682));         // 13
			cb_rus_V.Items.Add(Convert.ToChar(7684));         // 14
			cb_rus_V.Items.Add(Convert.ToChar(7686));         // 15
			cb_rus_V.Items.Add(Convert.ToChar(7838));         // 16
			cb_rus_V.Items.Add(Convert.ToChar(8383));         // 17
			cb_rus_V.Items.Add(Convert.ToChar(42192));         // 18

			// 223		ß
			// 579		Ƀ
			// 946		β
			// 1042		В
			// 1349		Յ
			// 3435		൫
			// 3647		฿
			// 4330		ც
			// 5104		Ᏸ
			// 5108		Ᏼ
			// 5725		ᙝ
			// 5726        ᙞ
			// 5727        ᙟ
			// 7682		Ḃ
			// 7684		Ḅ
			// 7686		Ḇ
			// 7838		ẞ
			// 8383		₿
			// 42192		ꓐ
		}

		private void FillBoxes_rus_v()
		{
			cb_rus_v.Items.Add(Convert.ToChar(606));         // 0
			cb_rus_v.Items.Add(Convert.ToChar(665));         // 1
			cb_rus_v.Items.Add(Convert.ToChar(1074));         // 2
			cb_rus_v.Items.Add(Convert.ToChar(5112));         // 3
			cb_rus_v.Items.Add(Convert.ToChar(5116));         // 4
			cb_rus_v.Items.Add(Convert.ToChar(7427));         // 5
			cb_rus_v.Items.Add(Convert.ToChar(7470));         // 6
			cb_rus_v.Items.Add(Convert.ToChar(7471));         // 7
			cb_rus_v.Items.Add(Convert.ToChar(000));         // 8
			cb_rus_v.Items.Add(Convert.ToChar(000));         // 9

			// 606		ɞ
			// 665		ʙ
			// 1074		в
			// 5112		ᏸ
			// 5116		ᏼ
			// 7427		ᴃ
			// 7470		ᴮ
			// 7471     ᴯ
		}
	}
}
 
/*
 * MINI-FONT
7424		ᴀ
7425		ᴁ
7426		ᴂ
7427		ᴃ
7428		ᴄ
7429		ᴅ
7430		ᴆ
7431		ᴇ
7432		ᴈ
7433		ᴉ
7434		ᴊ
7435		ᴋ
7436		ᴌ
7437		ᴍ
7438		ᴎ
7439		ᴏ
7440		ᴐ
7441		ᴑ
7442		ᴒ
7443		ᴓ
7444		ᴔ
7445		ᴕ
7446		ᴖ
7447		ᴗ
7448		ᴘ
7449		ᴙ
7450		ᴚ
7451		ᴛ
7452		ᴜ
7453		ᴝ
7454		ᴞ
7455		ᴟ
7456		ᴠ
7457		ᴡ
7458		ᴢ
7459		ᴣ
7460		ᴤ
7461		ᴥ
7462		ᴦ
7463		ᴧ
7464		ᴨ
7465		ᴩ
7466		ᴪ
7467		ᴫ
7468		ᴬ
7469		ᴭ
7470		ᴮ
7471		ᴯ
7472		ᴰ
7473		ᴱ
7474		ᴲ
7475		ᴳ
7476		ᴴ
7477		ᴵ
7478		ᴶ
7479		ᴷ
7480		ᴸ
7481		ᴹ
7482		ᴺ
7483		ᴻ
7484		ᴼ
7485		ᴽ
7486		ᴾ
7487		ᴿ
7488		ᵀ
7489		ᵁ
7490		ᵂ
7491		ᵃ
7492		ᵄ
7493		ᵅ
7494		ᵆ
7495		ᵇ
7496		ᵈ
7497		ᵉ
7498		ᵊ
7499		ᵋ
7500		ᵌ
7501		ᵍ
7502		ᵎ
7503		ᵏ
7504		ᵐ
7505		ᵑ
7506		ᵒ
7507		ᵓ
7508		ᵔ
7509		ᵕ
7510		ᵖ
7511		ᵗ
7512		ᵘ
7513		ᵙ
7514		ᵚ
7515		ᵛ
7516		ᵜ
7517		ᵝ
7518		ᵞ
7519		ᵟ
7520		ᵠ
7521		ᵡ
7522		ᵢ
7523		ᵣ
7524		ᵤ
7525		ᵥ
7526		ᵦ
7527		ᵧ
7528		ᵨ
7529		ᵩ
7530		ᵪ
7531		ᵫ
7532		ᵬ
7533		ᵭ
7534		ᵮ
7535		ᵯ
7536		ᵰ
7537		ᵱ
7538		ᵲ
7539		ᵳ
7540		ᵴ
7541		ᵵ
7542		ᵶ
7543		ᵷ
7544		ᵸ
7545		ᵹ
7546		ᵺ
7547		ᵻ
7548		ᵼ
7549		ᵽ
7550		ᵾ
7551		ᵿ
7552		ᶀ
7553		ᶁ
7554		ᶂ
7555		ᶃ
7556		ᶄ
7557		ᶅ
7558		ᶆ
7559		ᶇ
7560		ᶈ
7561		ᶉ
7562		ᶊ
7563		ᶋ
7564		ᶌ
7565		ᶍ
7566		ᶎ
7567		ᶏ
7568		ᶐ
7569		ᶑ
7570		ᶒ
7571		ᶓ
7572		ᶔ
7573		ᶕ
7574		ᶖ
7575		ᶗ
7576		ᶘ
7577		ᶙ
7578		ᶚ
7579		ᶛ
7580		ᶜ
7581		ᶝ
7582		ᶞ
7583		ᶟ
7584		ᶠ
7585		ᶡ
7586		ᶢ
7587		ᶣ
7588		ᶤ
7589		ᶥ
7590		ᶦ
7591		ᶧ
7592		ᶨ
7593		ᶩ
7594		ᶪ
7595		ᶫ
7596		ᶬ
7597		ᶭ
7598		ᶮ
7599		ᶯ
7600		ᶰ
7601		ᶱ
7602		ᶲ
7603		ᶳ
7604		ᶴ
7605		ᶵ
7606		ᶶ
7607		ᶷ
7608		ᶸ
7609		ᶹ
7610		ᶺ
7611		ᶻ
7612		ᶼ
7613		ᶽ
7614		ᶾ
7615		ᶿ
7616		᷀
7617		᷁
7618		᷂
7619		᷃
7620		᷄
7621		᷅
7622		᷆
7623		᷇
7624		᷈
7625		᷉
*/