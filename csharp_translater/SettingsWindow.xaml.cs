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

			FillBoxes_rus_G();
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

			/*FillBoxes_rus_K();
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

			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
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
			cb_rus_A.Items.Add(Convert.ToChar(7424));       // 69


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
			// 7424        ᴀ
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
			cb_rus_B.Items.Add(Convert.ToChar(1172));         // 2
			cb_rus_B.Items.Add(Convert.ToChar(19970));         // 3
			cb_rus_B.Items.Add(Convert.ToChar(19975));         // 4
			cb_rus_B.Items.Add(Convert.ToChar(43074));         // 5

			// 386     Ƃ
			// 387     ƃ
			// 1172		Ҕ
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

		/*	Г	*/
		private void FillBoxes_rus_G()
		{
			cb_rus_G.Items.Add(Convert.ToChar(915));         // 0
			cb_rus_G.Items.Add(Convert.ToChar(1027));         // 1
			cb_rus_G.Items.Add(Convert.ToChar(1043));         // 2
			cb_rus_G.Items.Add(Convert.ToChar(1168));         // 3
			cb_rus_G.Items.Add(Convert.ToChar(1170));         // 4
			cb_rus_G.Items.Add(Convert.ToChar(1270));         // 5
			cb_rus_G.Items.Add(Convert.ToChar(1498));         // 6
			cb_rus_G.Items.Add(Convert.ToChar(2006));         // 7
			cb_rus_G.Items.Add(Convert.ToChar(5045));         // 8
			cb_rus_G.Items.Add(Convert.ToChar(5258));         // 9
			cb_rus_G.Items.Add(Convert.ToChar(5259));         // 10
			cb_rus_G.Items.Add(Convert.ToChar(5260));         // 11
			cb_rus_G.Items.Add(Convert.ToChar(5268));         // 12
			cb_rus_G.Items.Add(Convert.ToChar(5269));         // 13
			cb_rus_G.Items.Add(Convert.ToChar(5270));         // 14
			cb_rus_G.Items.Add(Convert.ToChar(5271));         // 15
			cb_rus_G.Items.Add(Convert.ToChar(5284));         // 16
			cb_rus_G.Items.Add(Convert.ToChar(5285));         // 17
			cb_rus_G.Items.Add(Convert.ToChar(5286));         // 18
			cb_rus_G.Items.Add(Convert.ToChar(5294));         // 19
			cb_rus_G.Items.Add(Convert.ToChar(5295));         // 20
			cb_rus_G.Items.Add(Convert.ToChar(5296));         // 21
			cb_rus_G.Items.Add(Convert.ToChar(5297));         // 22
			cb_rus_G.Items.Add(Convert.ToChar(5392));         // 23
			cb_rus_G.Items.Add(Convert.ToChar(5399));         // 24
			cb_rus_G.Items.Add(Convert.ToChar(5400));         // 25

			// 915		Γ               
			// 1027		Ѓ
			// 1043		Г
			// 1168		Ґ
			// 1170		Ғ
			// 1270		Ӷ
			// 1498		ך
			// 2006		ߖ
			// 5045		Ꮅ
			// 5258        ᒊ
			// 5259        ᒋ
			// 5260        ᒌ
			// 5268        ᒔ
			// 5269        ᒕ
			// 5270        ᒖ
			// 5271        ᒗ
			// 5284        ᒤ
			// 5285        ᒥ
			// 5286        ᒦ
			// 5294        ᒮ
			// 5295        ᒯ
			// 5296        ᒰ
			// 5297        ᒱ
			// 5392			ᔐ
			// 5399			ᔗ
			// 5400			ᔘ
		}

		private void FillBoxes_rus_g()
		{
			cb_rus_g.Items.Add(Convert.ToChar(1075));         // 0
			cb_rus_g.Items.Add(Convert.ToChar(1169));         // 1
			cb_rus_g.Items.Add(Convert.ToChar(1171));         // 2
			cb_rus_g.Items.Add(Convert.ToChar(1275));         // 3
			cb_rus_g.Items.Add(Convert.ToChar(1360));         // 4
			cb_rus_g.Items.Add(Convert.ToChar(1408));         // 5
			cb_rus_g.Items.Add(Convert.ToChar(2719));         // 6
			cb_rus_g.Items.Add(Convert.ToChar(2722));         // 7
			cb_rus_g.Items.Add(Convert.ToChar(4971));         // 8
			cb_rus_g.Items.Add(Convert.ToChar(7460));         // 9
			cb_rus_g.Items.Add(Convert.ToChar(7462));         // 10

			// 1075		г
			// 1169		ґ
			// 1171		ғ
			// 1271		ӷ
			// 1275		ӻ
			// 1360		Ր
			// 1408		ր
			// 2719		ટ
			// 2722		ઢ
			// 4971		፫
			// 7460        ᴤ
			// 7462		ᴦ
		}

		/*	Д	*/
		private void FillBoxes_rus_D()
		{
			cb_rus_D.Items.Add(Convert.ToChar(68));         // 0
			cb_rus_D.Items.Add(Convert.ToChar(270));         // 1
			cb_rus_D.Items.Add(Convert.ToChar(1044));         // 2
			cb_rus_D.Items.Add(Convert.ToChar(1324));         // 3
			cb_rus_D.Items.Add(Convert.ToChar(5024));         // 4
			cb_rus_D.Items.Add(Convert.ToChar(7429));         // 5
			cb_rus_D.Items.Add(Convert.ToChar(7430));         // 6
			cb_rus_D.Items.Add(Convert.ToChar(7472));         // 7

			// 68		D
			// 270		Ď
			// 1044		Д
			// 1324		Ԭ
			// 5024		Ꭰ
			// 7429		ᴅ
			// 7430        ᴆ
			// 7472		ᴰ
		}

		private void FillBoxes_rus_d()
		{
			cb_rus_d.Items.Add(Convert.ToChar(103));         // 0
			cb_rus_d.Items.Add(Convert.ToChar(285));         // 1
			cb_rus_d.Items.Add(Convert.ToChar(287));         // 2
			cb_rus_d.Items.Add(Convert.ToChar(289));         // 3
			cb_rus_d.Items.Add(Convert.ToChar(485));         // 4
			cb_rus_d.Items.Add(Convert.ToChar(501));         // 5
			cb_rus_d.Items.Add(Convert.ToChar(608));         // 6
			cb_rus_d.Items.Add(Convert.ToChar(609));         // 7
			cb_rus_d.Items.Add(Convert.ToChar(1076));         // 8
			cb_rus_d.Items.Add(Convert.ToChar(1325));         // 9
			cb_rus_d.Items.Add(Convert.ToChar(7501));         // 10
			cb_rus_d.Items.Add(Convert.ToChar(7586));         // 11
			cb_rus_d.Items.Add(Convert.ToChar(7713));         // 12
			cb_rus_d.Items.Add(Convert.ToChar(43124));         // 13

			// 103		g
			// 285		ĝ
			// 287		ğ
			// 289		ġ
			// 291		ģ
			// 485		ǥ
			// 501		ǵ
			// 608		ɠ
			// 609     ɡ
			// 1076		д
			// 1325		ԭ
			// 7501		ᵍ
			// 7586        ᶢ
			// 7713		ḡ
			// 43124		꡴
		}

		/*	Е	*/

		private void FillBoxes_rus_E()
		{
			cb_rus_E.Items.Add(Convert.ToChar(69));         // 0
			cb_rus_E.Items.Add(Convert.ToChar(280));         // 1
			cb_rus_E.Items.Add(Convert.ToChar(400));         // 2
			cb_rus_E.Items.Add(Convert.ToChar(552));         // 3
			cb_rus_E.Items.Add(Convert.ToChar(582));         // 4
			cb_rus_E.Items.Add(Convert.ToChar(904));         // 5
			cb_rus_E.Items.Add(Convert.ToChar(917));         // 6
			cb_rus_E.Items.Add(Convert.ToChar(931));         // 7
			cb_rus_E.Items.Add(Convert.ToChar(958));         // 8
			cb_rus_E.Items.Add(Convert.ToChar(1028));         // 9
			cb_rus_E.Items.Add(Convert.ToChar(1045));         // 10
			cb_rus_E.Items.Add(Convert.ToChar(1212));         // 11
			cb_rus_E.Items.Add(Convert.ToChar(1214));         // 12
			cb_rus_E.Items.Add(Convert.ToChar(1296));         // 13
			cb_rus_E.Items.Add(Convert.ToChar(5067));         // 14
			cb_rus_E.Items.Add(Convert.ToChar(7431));         // 15
			cb_rus_E.Items.Add(Convert.ToChar(7473));         // 16
			cb_rus_E.Items.Add(Convert.ToChar(7704));         // 17
			cb_rus_E.Items.Add(Convert.ToChar(7706));         // 18
			cb_rus_E.Items.Add(Convert.ToChar(7864));         // 19
			cb_rus_E.Items.Add(Convert.ToChar(7960));         // 20
			cb_rus_E.Items.Add(Convert.ToChar(7961));         // 21
			cb_rus_E.Items.Add(Convert.ToChar(7962));         // 22
			cb_rus_E.Items.Add(Convert.ToChar(7963));         // 23
			cb_rus_E.Items.Add(Convert.ToChar(7964));         // 24
			cb_rus_E.Items.Add(Convert.ToChar(7965));         // 25
			cb_rus_E.Items.Add(Convert.ToChar(8364));         // 26
			cb_rus_E.Items.Add(Convert.ToChar(42160));         // 27
			cb_rus_E.Items.Add(Convert.ToChar(42224));         // 28
			cb_rus_E.Items.Add(Convert.ToChar(43072));         // 29

			// 69		E
			// 280     Ę
			// 400		Ɛ
			// 552		Ȩ
			// 582		Ɇ
			// 904		Έ
			// 917		Ε
			// 931		Σ
			// 958		ξ
			// 1028		Є
			// 1045		Е
			// 1212		Ҽ
			// 1214		Ҿ
			// 1296		Ԑ
			// 5067		Ꮛ
			// 7431     ᴇ
			// 7473		ᴱ
			// 7704		Ḙ
			// 7706		Ḛ
			// 7864        Ẹ
			// 7960		Ἐ
			// 7961        Ἑ
			// 7962        Ἒ
			// 7963        Ἓ
			// 7964        Ἔ
			// 7965        Ἕ
			// 8364		€
			// 42160		꒰
			// 42224		ꓰ
			// 43072		ꡀ
		}

		private void FillBoxes_rus_e()
		{
			cb_rus_e.Items.Add(Convert.ToChar(101));         // 0
			cb_rus_e.Items.Add(Convert.ToChar(281));         // 1
			cb_rus_e.Items.Add(Convert.ToChar(553));         // 2
			cb_rus_e.Items.Add(Convert.ToChar(583));         // 3
			cb_rus_e.Items.Add(Convert.ToChar(868));         // 4
			cb_rus_e.Items.Add(Convert.ToChar(949));         // 5
			cb_rus_e.Items.Add(Convert.ToChar(1009));         // 6
			cb_rus_e.Items.Add(Convert.ToChar(1013));         // 7
			cb_rus_e.Items.Add(Convert.ToChar(1077));         // 8
			cb_rus_e.Items.Add(Convert.ToChar(1213));         // 9
			cb_rus_e.Items.Add(Convert.ToChar(1215));         // 10
			cb_rus_e.Items.Add(Convert.ToChar(1297));         // 11
			cb_rus_e.Items.Add(Convert.ToChar(7497));         // 12
			cb_rus_e.Items.Add(Convert.ToChar(7499));         // 13
			cb_rus_e.Items.Add(Convert.ToChar(7570));         // 14
			cb_rus_e.Items.Add(Convert.ToChar(7571));         // 15
			cb_rus_e.Items.Add(Convert.ToChar(7705));         // 16
			cb_rus_e.Items.Add(Convert.ToChar(7707));         // 17
			cb_rus_e.Items.Add(Convert.ToChar(7865));         // 18
			cb_rus_e.Items.Add(Convert.ToChar(8337));         // 19
			cb_rus_e.Items.Add(Convert.ToChar(11384));         // 20

			// 101		e
			// 281     ę
			// 553		ȩ
			// 583		ɇ
			// 868		ͤ
			// 949		ε
			// 1009		ϱ
			// 1013		ϵ
			// 1077		е
			// 1213		ҽ
			// 1215		ҿ
			// 1297		ԑ
			// 7497		ᵉ
			// 7499		ᵋ
			// 7570		ᶒ
			// 7571     ᶓ
			// 7705		ḙ
			// 7707		ḛ
			// 7865        ẹ
			// 8337		ₑ
			// 11384		ⱸ
		}

		/*	Ё	*/

		private void FillBoxes_rus_YO()
		{
			cb_rus_YO.Items.Add(Convert.ToChar(200));         // 0
			cb_rus_YO.Items.Add(Convert.ToChar(201));         // 1
			cb_rus_YO.Items.Add(Convert.ToChar(202));         // 2
			cb_rus_YO.Items.Add(Convert.ToChar(203));         // 3
			cb_rus_YO.Items.Add(Convert.ToChar(274));         // 4
			cb_rus_YO.Items.Add(Convert.ToChar(276));         // 5
			cb_rus_YO.Items.Add(Convert.ToChar(278));         // 6
			cb_rus_YO.Items.Add(Convert.ToChar(282));         // 7
			cb_rus_YO.Items.Add(Convert.ToChar(516));         // 8
			cb_rus_YO.Items.Add(Convert.ToChar(518));         // 9
			cb_rus_YO.Items.Add(Convert.ToChar(1238));         // 10
			cb_rus_YO.Items.Add(Convert.ToChar(7700));         // 11
			cb_rus_YO.Items.Add(Convert.ToChar(7702));         // 12
			cb_rus_YO.Items.Add(Convert.ToChar(7708));         // 13
			cb_rus_YO.Items.Add(Convert.ToChar(7866));         // 14
			cb_rus_YO.Items.Add(Convert.ToChar(7868));         // 15
			cb_rus_YO.Items.Add(Convert.ToChar(7870));         // 16
			cb_rus_YO.Items.Add(Convert.ToChar(7872));         // 17
			cb_rus_YO.Items.Add(Convert.ToChar(7874));         // 18
			cb_rus_YO.Items.Add(Convert.ToChar(7876));         // 19
			cb_rus_YO.Items.Add(Convert.ToChar(7878));         // 20

			// 200		È
			// 201     É
			// 202     Ê
			// 203     Ë
			// 274     Ē
			// 276     Ĕ
			// 278     Ė
			// 282     Ě
			// 516		Ȅ
			// 518		Ȇ
			// 1238		Ӗ
			// 7700		Ḕ
			// 7702		Ḗ
			// 7708		Ḝ
			// 7866        Ẻ
			// 7868        Ẽ
			// 7870        Ế
			// 7872        Ề
			// 7874        Ể
			// 7876        Ễ
			// 7878        Ệ
		}

		private void FillBoxes_rus_yo()
		{
			cb_rus_yo.Items.Add(Convert.ToChar(232));         // 0
			cb_rus_yo.Items.Add(Convert.ToChar(233));         // 1
			cb_rus_yo.Items.Add(Convert.ToChar(234));         // 2
			cb_rus_yo.Items.Add(Convert.ToChar(235));         // 3
			cb_rus_yo.Items.Add(Convert.ToChar(275));         // 4
			cb_rus_yo.Items.Add(Convert.ToChar(277));         // 5
			cb_rus_yo.Items.Add(Convert.ToChar(279));         // 6
			cb_rus_yo.Items.Add(Convert.ToChar(283));         // 7
			cb_rus_yo.Items.Add(Convert.ToChar(517));         // 8
			cb_rus_yo.Items.Add(Convert.ToChar(519));         // 9
			cb_rus_yo.Items.Add(Convert.ToChar(941));         // 10
			cb_rus_yo.Items.Add(Convert.ToChar(1239));         // 11
			cb_rus_yo.Items.Add(Convert.ToChar(7701));         // 12
			cb_rus_yo.Items.Add(Convert.ToChar(7703));         // 13
			cb_rus_yo.Items.Add(Convert.ToChar(7709));         // 14
			cb_rus_yo.Items.Add(Convert.ToChar(7867));         // 15
			cb_rus_yo.Items.Add(Convert.ToChar(7869));         // 16
			cb_rus_yo.Items.Add(Convert.ToChar(7871));         // 17
			cb_rus_yo.Items.Add(Convert.ToChar(7873));         // 18
			cb_rus_yo.Items.Add(Convert.ToChar(7875));         // 19
			cb_rus_yo.Items.Add(Convert.ToChar(7877));         // 20
			cb_rus_yo.Items.Add(Convert.ToChar(7879));         // 21

			// 232		è
			// 233     é
			// 234     ê
			// 235     ë
			// 275     ē
			// 277     ĕ
			// 279     ė
			// 283     ě
			// 517		ȅ
			// 519		ȇ
			// 941		έ
			// 1239		ӗ
			// 7701		ḕ
			// 7703		ḗ
			// 7709		ḝ
			// 7867        ẻ	
			// 7869        ẽ
			// 7871        ế
			// 7873        ề
			// 7875        ể
			// 7877        ễ
			// 7879        ệ
		}

		/*	Ж	*/

		private void FillBoxes_rus_ZH()
		{
			cb_rus_ZH.Items.Add(Convert.ToChar(1046));         // 0
			cb_rus_ZH.Items.Add(Convert.ToChar(1174));         // 1
			cb_rus_ZH.Items.Add(Convert.ToChar(1217));         // 2
			cb_rus_ZH.Items.Add(Convert.ToChar(1244));         // 3

			// 1046		Ж
			// 1174		Җ
			// 1217		Ӂ
			// 1244		Ӝ
		}

		private void FillBoxes_rus_zh()
		{
			cb_rus_zh.Items.Add(Convert.ToChar(1078));         // 0
			cb_rus_zh.Items.Add(Convert.ToChar(1175));         // 1
			cb_rus_zh.Items.Add(Convert.ToChar(1218));         // 2
			cb_rus_zh.Items.Add(Convert.ToChar(1245));         // 3

			// 1078		ж
			// 1175		җ
			// 1218		ӂ
			// 1245		ӝ
		}

		/*	З	*/

		private void FillBoxes_rus_Z()
		{
			cb_rus_Z.Items.Add(Convert.ToChar(439));         // 0
			cb_rus_Z.Items.Add(Convert.ToChar(494));         // 1
			cb_rus_Z.Items.Add(Convert.ToChar(540));         // 2
			cb_rus_Z.Items.Add(Convert.ToChar(658));         // 3
			cb_rus_Z.Items.Add(Convert.ToChar(659));         // 4
			cb_rus_Z.Items.Add(Convert.ToChar(1047));         // 5
			cb_rus_Z.Items.Add(Convert.ToChar(1176));         // 6
			cb_rus_Z.Items.Add(Convert.ToChar(1246));         // 7
			cb_rus_Z.Items.Add(Convert.ToChar(1248));         // 8
			cb_rus_Z.Items.Add(Convert.ToChar(1349));         // 9
			cb_rus_Z.Items.Add(Convert.ToChar(2793));         // 10
			cb_rus_Z.Items.Add(Convert.ToChar(5052));         // 11
			cb_rus_Z.Items.Add(Convert.ToChar(42161));         // 12
			cb_rus_Z.Items.Add(Convert.ToChar(43095));         // 13
			cb_rus_Z.Items.Add(Convert.ToChar(43507));         // 14

			// 439		Ʒ
			// 494		Ǯ
			// 540		Ȝ
			// 658		ʒ
			// 659     ʓ
			// 1047		З
			// 1176		Ҙ
			// 1246		Ӟ
			// 1248        Ӡ
			// 1349		Յ
			// 2793		૩
			// 5052		Ꮌ
			// 42161		꒱
			// 43095		ꡗ
			// 43507		꧳
		}

		private void FillBoxes_rus_z()
		{
			cb_rus_z.Items.Add(Convert.ToChar(442));         // 0
			cb_rus_z.Items.Add(Convert.ToChar(495));         // 1
			cb_rus_z.Items.Add(Convert.ToChar(541));         // 2
			cb_rus_z.Items.Add(Convert.ToChar(604));         // 3
			cb_rus_z.Items.Add(Convert.ToChar(605));         // 4
			cb_rus_z.Items.Add(Convert.ToChar(1079));         // 5
			cb_rus_z.Items.Add(Convert.ToChar(1177));         // 6
			cb_rus_z.Items.Add(Convert.ToChar(1247));         // 7
			cb_rus_z.Items.Add(Convert.ToChar(1249));         // 8
			cb_rus_z.Items.Add(Convert.ToChar(4339));         // 9
			cb_rus_z.Items.Add(Convert.ToChar(7459));         // 10
			cb_rus_z.Items.Add(Convert.ToChar(7578));         // 11
			cb_rus_z.Items.Add(Convert.ToChar(7583));         // 12

			// 442		ƺ
			// 495		ǯ
			// 541		ȝ
			// 604		ɜ
			// 605     ɝ
			// 1079		з
			// 1177		ҙ
			// 1247		ӟ
			// 1249		ӡ
			// 4339		ჳ
			// 7459		ᴣ
			// 7578		ᶚ
			// 7583		ᶟ
		}

		/*	И	*/

		private void FillBoxes_rus_I()
		{
			cb_rus_I.Items.Add(Convert.ToChar(431));         // 0
			cb_rus_I.Items.Add(Convert.ToChar(434));         // 1
			cb_rus_I.Items.Add(Convert.ToChar(580));         // 2
			cb_rus_I.Items.Add(Convert.ToChar(886));         // 3
			cb_rus_I.Items.Add(Convert.ToChar(1048));         // 4
			cb_rus_A.Items.Add(Convert.ToChar(7794));         // 5
			cb_rus_I.Items.Add(Convert.ToChar(7796));         // 6
			cb_rus_I.Items.Add(Convert.ToChar(7798));         // 7
			cb_rus_I.Items.Add(Convert.ToChar(7908));         // 8
			cb_rus_I.Items.Add(Convert.ToChar(7920));         // 9
			cb_rus_I.Items.Add(Convert.ToChar(42148));         // 10

			// 431		Ư
			// 434		Ʋ
			// 580		Ʉ
			// 886		Ͷ
			// 1048		И
			// 7794        Ṳ
			// 7796        Ṵ
			// 7798        Ṷ
			// 7908        Ụ
			// 7920        Ự
			// 42148		꒤
		}

		private void FillBoxes_rus_i()
		{
			cb_rus_i.Items.Add(Convert.ToChar(432));         // 0
			cb_rus_i.Items.Add(Convert.ToChar(649));         // 1
			cb_rus_i.Items.Add(Convert.ToChar(651));         // 2
			cb_rus_i.Items.Add(Convert.ToChar(871));         // 3
			cb_rus_i.Items.Add(Convert.ToChar(887));         // 4
			cb_rus_i.Items.Add(Convert.ToChar(956));         // 5
			cb_rus_i.Items.Add(Convert.ToChar(965));         // 6
			cb_rus_i.Items.Add(Convert.ToChar(983));         // 7
			cb_rus_i.Items.Add(Convert.ToChar(1008));         // 8
			cb_rus_i.Items.Add(Convert.ToChar(1080));         // 9
			cb_rus_i.Items.Add(Convert.ToChar(7524));         // 10
			cb_rus_i.Items.Add(Convert.ToChar(7608));         // 11
			cb_rus_i.Items.Add(Convert.ToChar(7609));         // 12
			cb_rus_i.Items.Add(Convert.ToChar(7795));         // 13
			cb_rus_i.Items.Add(Convert.ToChar(7797));         // 14
			cb_rus_i.Items.Add(Convert.ToChar(7799));         // 15
			cb_rus_i.Items.Add(Convert.ToChar(7909));         // 16
			cb_rus_i.Items.Add(Convert.ToChar(11534));         // 17

			// 432		ư
			// 649		ʉ
			// 651		ʋ
			// 871		ͧ
			// 887		ͷ
			// 956		μ
			// 965		υ
			// 983		ϗ
			// 1008		ϰ
			// 1080		и
			// 7524		ᵤ
			// 7608		ᶸ
			// 7609		ᶹ
			// 7795        ṳ
			// 7797        ṵ
			// 7799        ṷ
			// 7909        ụ
			// 11534		ⴎ
		}

		/*	Й	*/

		private void FillBoxes_rus_IK()
		{
			cb_rus_IK.Items.Add(Convert.ToChar(467));         // 0
			cb_rus_IK.Items.Add(Convert.ToChar(469));         // 1
			cb_rus_IK.Items.Add(Convert.ToChar(471));         // 2
			cb_rus_IK.Items.Add(Convert.ToChar(473));         // 3
			cb_rus_IK.Items.Add(Convert.ToChar(475));         // 4
			cb_rus_IK.Items.Add(Convert.ToChar(532));         // 5
			cb_rus_IK.Items.Add(Convert.ToChar(534));         // 6
			cb_rus_IK.Items.Add(Convert.ToChar(1037));         // 7
			cb_rus_IK.Items.Add(Convert.ToChar(1049));         // 8
			cb_rus_IK.Items.Add(Convert.ToChar(1162));         // 9
			cb_rus_IK.Items.Add(Convert.ToChar(1250));         // 10
			cb_rus_IK.Items.Add(Convert.ToChar(1252));         // 11
			cb_rus_IK.Items.Add(Convert.ToChar(7800));         // 12
			cb_rus_IK.Items.Add(Convert.ToChar(7802));         // 13
			cb_rus_IK.Items.Add(Convert.ToChar(7910));         // 14
			cb_rus_IK.Items.Add(Convert.ToChar(7912));         // 15
			cb_rus_IK.Items.Add(Convert.ToChar(7914));         // 16
			cb_rus_IK.Items.Add(Convert.ToChar(7916));         // 17
			cb_rus_IK.Items.Add(Convert.ToChar(7918));         // 18

			// 467		Ǔ	
			// 469     Ǖ
			// 471     Ǘ
			// 473     Ǚ
			// 475     Ǜ
			// 532		Ȕ
			// 534		Ȗ
			// 1037		Ѝ
			// 1049		Й
			// 1162		Ҋ
			// 1250		Ӣ
			// 1252		Ӥ
			// 7800        Ṹ
			// 7802        Ṻ
			// 7910        Ủ
			// 7912        Ứ
			// 7914        Ừ
			// 7916        Ử
			// 7918        Ữ
		}

		private void FillBoxes_rus_ik()
		{
			cb_rus_ik.Items.Add(Convert.ToChar(468));         // 0
			cb_rus_ik.Items.Add(Convert.ToChar(470));         // 1
			cb_rus_ik.Items.Add(Convert.ToChar(472));         // 2
			cb_rus_ik.Items.Add(Convert.ToChar(474));         // 3
			cb_rus_ik.Items.Add(Convert.ToChar(476));         // 4
			cb_rus_ik.Items.Add(Convert.ToChar(533));         // 5
			cb_rus_ik.Items.Add(Convert.ToChar(535));         // 6
			cb_rus_ik.Items.Add(Convert.ToChar(971));         // 7
			cb_rus_ik.Items.Add(Convert.ToChar(973));         // 8
			cb_rus_ik.Items.Add(Convert.ToChar(1081));         // 9
			cb_rus_ik.Items.Add(Convert.ToChar(1117));         // 10
			cb_rus_ik.Items.Add(Convert.ToChar(1163));         // 11
			cb_rus_ik.Items.Add(Convert.ToChar(1251));         // 12
			cb_rus_ik.Items.Add(Convert.ToChar(1253));         // 13
			cb_rus_ik.Items.Add(Convert.ToChar(7801));         // 14
			cb_rus_ik.Items.Add(Convert.ToChar(7803));         // 15
			cb_rus_ik.Items.Add(Convert.ToChar(7911));         // 16
			cb_rus_ik.Items.Add(Convert.ToChar(7913));         // 17
			cb_rus_ik.Items.Add(Convert.ToChar(7915));         // 18
			cb_rus_ik.Items.Add(Convert.ToChar(7917));         // 19
			cb_rus_ik.Items.Add(Convert.ToChar(7919));         // 20
			cb_rus_ik.Items.Add(Convert.ToChar(7921));         // 21
			cb_rus_ik.Items.Add(Convert.ToChar(8016));         // 22
			cb_rus_ik.Items.Add(Convert.ToChar(8017));         // 23
			cb_rus_ik.Items.Add(Convert.ToChar(8018));         // 24
			cb_rus_ik.Items.Add(Convert.ToChar(8019));         // 25
			cb_rus_ik.Items.Add(Convert.ToChar(8020));         // 26
			cb_rus_ik.Items.Add(Convert.ToChar(8021));         // 27
			cb_rus_ik.Items.Add(Convert.ToChar(8021));         // 28
			cb_rus_ik.Items.Add(Convert.ToChar(8023));         // 29
			cb_rus_ik.Items.Add(Convert.ToChar(8160));         // 30
			cb_rus_ik.Items.Add(Convert.ToChar(8161));         // 31
			cb_rus_ik.Items.Add(Convert.ToChar(8162));         // 32
			cb_rus_ik.Items.Add(Convert.ToChar(8163));         // 33
			cb_rus_ik.Items.Add(Convert.ToChar(8166));         // 34
			cb_rus_ik.Items.Add(Convert.ToChar(8167));         // 35

			// 468     ǔ
			// 470     ǖ
			// 472     ǘ
			// 474     ǚ
			// 476     ǜ
			// 533		ȕ
			// 535		ȗ
			// 971		ϋ
			// 973		ύ
			// 1081		й
			// 1117		ѝ
			// 1163		ҋ
			// 1251		ӣ
			// 1253        ӥ
			// 7801        ṹ
			// 7803        ṻ
			// 7911        ủ
			// 7913        ứ
			// 7915        ừ
			// 7917        ử
			// 7919        ữ
			// 7921        ự
			// 8016		ὐ
			// 8017        ὑ
			// 8018        ὒ
			// 8019        ὓ
			// 8020        ὔ
			// 8021        ὕ
			// 8022        ὖ
			// 8023        ὗ
			// 8160		ῠ
			// 8161        ῡ
			// 8162        ῢ
			// 8163        ΰ
			// 8166		ῦ
			// 8167        ῧ
		}
	}
}
