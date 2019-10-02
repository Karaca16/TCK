using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCK
{
    public partial class frm_TCK_ANASAYFA : Form
    {
        public frm_TCK_ANASAYFA()
        {
            InitializeComponent();
        }
        string Crime;
        public static string Suc1 = "Bos", Suc2 = "Bos";
        public static string Crime1, Crime2;
        frm_questions newfrm = new frm_questions();

        private void TCK_ANASAYFA_Load(object sender, EventArgs e)
        {
            cmb4.Enabled = false;
            lbl_WarningDate.Visible = false;
            btn_AddCrime.Enabled = false;
            label4.Text = Suc1;
            label14.Text = Suc2;
            btn_AllCrime.Enabled = false;
            btn_SelectedCrime.Enabled = false;
            btn_ShowPunishment.Enabled = false;
        }
        void Temizle()
        {
            cmb1.Text = "";
            cmb2.Text = "";
            cmb2.Items.Clear();
            cmb3.Text = "";
            cmb3.Items.Clear();
            cmb4.Text = "";
            cmb4.Items.Clear();
        }
        void Warning()
        {
            lbl_WarningDate.Visible = true;
            dt_CrimeDate.Enabled = false;
            lbl1.ForeColor = Color.Gray;
        }
        void AddCrime()
        {
            Crime = cmb3.Text;
            if (cmb4.SelectedIndex != -1) Crime = cmb3.Text + " -- " + cmb4.Text;
            lst_Crime.Items.Add(Crime);
            Temizle();
        }
        private void btn_AddCrime_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_LastName.Text != "" && nm_Age.Value.ToString() != "" && cmb_Graduation.Text != "" && cmb_Job.Text != "" && cmb_Nationality.Text != "")
            {
                btn_AllCrime.Enabled = true;
                btn_SelectedCrime.Enabled = true;
                btn_ShowPunishment.Enabled = true;
                if (lst_Crime.Items.Count < 2)
                {

                    if (Suc1 == "Bos" && Suc2 == "Bos")
                    {
                        Suc1 = cmb1.SelectedIndex.ToString() + cmb2.SelectedIndex.ToString() + cmb3.SelectedIndex.ToString();
                        if (cmb4.SelectedIndex != -1) Suc1 = cmb1.SelectedIndex.ToString() + cmb2.SelectedIndex.ToString() + cmb3.SelectedIndex.ToString() + cmb4.SelectedIndex.ToString();
                        label4.Text = Suc1;
                        AddCrime();
                    }
                    else if (Suc1 != "Bos" && Suc2 == "Bos")
                    {
                        Suc2 = cmb1.SelectedIndex.ToString() + cmb2.SelectedIndex.ToString() + cmb3.SelectedIndex.ToString();
                        if (cmb4.SelectedIndex != -1) Suc2 = cmb1.SelectedIndex.ToString() + cmb2.SelectedIndex.ToString() + cmb3.SelectedIndex.ToString() + cmb4.SelectedIndex.ToString();
                        label14.Text = Suc2;
                        AddCrime();
                    }
                    else if (Suc1 == "Bos" && Suc2 != "Bos")
                    {
                        Suc1 = cmb1.SelectedIndex.ToString() + cmb2.SelectedIndex.ToString() + cmb3.SelectedIndex.ToString();
                        if (cmb4.SelectedIndex != -1) Suc1 = cmb1.SelectedIndex.ToString() + cmb2.SelectedIndex.ToString() + cmb3.SelectedIndex.ToString() + cmb4.SelectedIndex.ToString();
                        label4.Text = Suc1;
                        AddCrime();
                    }
                    else if (Suc1 != "Bos" && Suc2 != "Bos")
                    {
                        Suc1 = cmb1.SelectedIndex.ToString() + cmb2.SelectedIndex.ToString() + cmb3.SelectedIndex.ToString();
                        if (cmb4.SelectedIndex != -1) Suc1 = cmb1.SelectedIndex.ToString() + cmb2.SelectedIndex.ToString() + cmb3.SelectedIndex.ToString() + cmb4.SelectedIndex.ToString();
                        label4.Text = Suc1;
                        AddCrime();
                    }

                }
                else if (lst_Crime.Items.Count >= 2)
                {
                    MessageBox.Show("En fazla 2 suç girilebilir.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz!");
            }
        }
        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb2.Text = "";
            cmb3.Text = "";
            cmb4.Text = "";
            cmb3.Items.Clear();
            cmb4.Items.Clear();
            cmb4.Enabled = false;
            if (cmb1.SelectedIndex == 0) //BİRİNCİ KISIM:ULUSLARARASI SUÇLAR 
            {
                cmb2.Items.Clear();
                cmb2.Items.Add("BİRİNCİ BÖLÜM : SOYKIRIM VE İNSANLIĞA KARŞI SUÇLAR.");
                cmb2.Items.Add("İKİNCİ BÖLÜM : GÖÇMEN KAÇAKÇILIĞI VE İNSAN TİCARETİ.");
            }
            else if (cmb1.SelectedIndex == 1) //KİŞİLERE KARŞI SUÇLAR
            {
                cmb2.Items.Clear();
                cmb2.Items.Add("BİRİNCİ BÖLÜM : HAYATA KARŞI SUÇLAR.");
                cmb2.Items.Add("İKİNCİ BÖLÜM : VÜCUT DOKUNULMAZLIĞINA KARŞI SUÇLAR.");
                cmb2.Items.Add("ÜÇÜNCÜ BÖLÜM : İŞKENCE VE EZİYET.");
                cmb2.Items.Add("DÖRDÜNCÜ BÖLÜM : KORUMA, GÖZETİM, YARDIM VEYA BİLDİRİM YÜKÜMLÜLÜĞÜNÜN İHLÂLİ.");
                cmb2.Items.Add("BEŞİNCİ BÖLÜM : ÇOCUK DÜŞÜRTME, DÜŞÜRME VEYA KISIRLAŞTIRMA.");
                cmb2.Items.Add("ALTINCI BÖLÜM : CİNSEL DOKUNULMAZLIĞA KARŞI SUÇLAR");
                cmb2.Items.Add("YEDİNCİ BÖLÜM : HÜRRİYETE KARŞI SUÇLAR.");
                cmb2.Items.Add("SEKİZİNCİ BÖLÜM : ŞEREFE KARŞI SUÇLAR.");
                cmb2.Items.Add("DOKUZUNCU BÖLÜM : ÖZEL HAYATA VE HAYATIN GİZLİ ALANINA KARŞI SUÇLAR.");
                cmb2.Items.Add("ONUNCU BÖLÜM : MALVARLIĞINA KARŞI SUÇLAR.");
            }
            else if (cmb1.SelectedIndex == 2) //ÜÇÜNCÜ KISIM : TOPLUMA KARŞI SUÇLAR 
            {
                cmb2.Items.Clear();
                cmb2.Items.Add("BİRİNCİ BÖLÜM : GENEL TEHLİKE YARATAN SUÇLAR.");
                cmb2.Items.Add("İKİNCİ BÖLÜM : ÇEVREYE KARŞI SUÇLAR.");
                cmb2.Items.Add("ÜÇÜNCÜ BÖLÜM : KAMUNUN SAĞLIĞINA KARŞI SUÇLAR.");
                cmb2.Items.Add("DÖRDÜNCÜ BÖLÜM : KAMU GÜVENİNE KARŞI SUÇLAR.");
                cmb2.Items.Add("BEŞİNCİ BÖLÜM : KAMU BARIŞINA KARŞI SUÇLAR.");
                cmb2.Items.Add("ALTINCI BÖLÜM : ULAŞIM ARAÇLARINA VEYA SABİT PLATFORMLARA KARŞI SUÇLAR.");
                cmb2.Items.Add("YEDİNCİ BÖLÜM : GENEL AHLÂKA KARŞI SUÇLAR.");
                cmb2.Items.Add("SEKİZİNCİ BÖLÜM : AİLE DÜZENİNE KARŞI SUÇLAR.");
                cmb2.Items.Add("DOKUZUNCU BÖLÜM : EKONOMİ, SANAYİ VE TİCARETE İLİŞKİN SUÇLAR.");
                cmb2.Items.Add("ONUNCU BÖLÜM : BİLİŞİM ALANINDA SUÇLAR.");
            }
            else if (cmb1.SelectedIndex == 3) //DÖRDÜNCÜ KISIM : MİLLETE VE DEVLETE KARŞI SUÇLAR VE SON HÜKÜMLER
            {
                cmb2.Items.Clear();
                cmb2.Items.Add("BİRİNCİ BÖLÜM : KAMU İDARESİNİN GÜVENİLİRLİĞİNE VE İŞLEYİŞİNE KARŞI SUÇLAR.");
                cmb2.Items.Add("İKİNCİ BÖLÜM : ADLİYEYE KARŞI SUÇLAR.");
                cmb2.Items.Add("ÜÇÜNCÜ BÖLÜM : DEVLETİN EGEMENLİK ALAMETLERİNE VE ORGANLARININ SAYGINLIĞINA KARŞI SUÇLAR.");
                cmb2.Items.Add("DÖRDÜNCÜ BÖLÜM : DEVLETİN GÜVENLİĞİNE KARŞI SUÇLAR.");
                cmb2.Items.Add("BEŞİNCİ BÖLÜM : ANAYASAL DÜZENE VE BU DÜZENİN İŞLEYİŞİNE KARŞI SUÇLAR.");
                cmb2.Items.Add("ALTINCI BÖLÜM : MİLLÎ SAVUNMAYA KARŞI SUÇLAR.");
                cmb2.Items.Add("YEDİNCİ BÖLÜM : DEVLET SIRLARINA KARŞI SUÇLAR VE CASUSLUK.");
                cmb2.Items.Add("SEKİZİNCİ BÖLÜM : YABANCI DEVLETLERLE OLAN İLİŞKİLERE KARŞI SUÇLAR.");
                cmb2.Items.Add("DOKUZUNCU BÖLÜM : SON HÜKÜMLER.");
            }
        }
        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb3.Text = "";
            //BİRİNCİ KISIM          
            if (cmb1.SelectedIndex == 0 && cmb2.SelectedIndex == 0) //BİRİNCİ KISIM - BİRİNCİ BÖLÜM 
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("SOYKIRIM.");
                cmb3.Items.Add("İNSANLIĞA KARŞI SUÇLAR.");
            }
            else if (cmb1.SelectedIndex == 0 && cmb2.SelectedIndex == 1) //BİRİNCİ KISIM - İKİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("GÖÇMEN KAÇAKÇILIĞI.");
                cmb3.Items.Add("İNSAN TİCARETİ.");
            }
            //İKİNCİ KISIM
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 0) //İKİNCİ KISIM - BİRİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("KASTEN ÖLDÜRME.");
                cmb3.Items.Add("KASTEN ÖLDÜRMENİN İHMALİ DAVRANIŞLA İŞLENMESİ.");
                cmb3.Items.Add("İNTİHARA YÖNLENDİRME.");
                cmb3.Items.Add("TAKSİRLE ÖLDÜRME.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 1) //İKİNCİ KISIM - İKİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("KASTEN YARALAMA.");
                cmb3.Items.Add("NETİCESİ SEBEBİYLE AĞIRLAŞMIŞ YARALAMA.");
                cmb3.Items.Add("TAKSİRLE YARALAMA.");
                cmb3.Items.Add("İNSAN ÜZERİNDE DENEY.");
                cmb3.Items.Add("ORGAN VEYA DOKU TİCARETİ.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 2) // İKİNCİ KISIM - ÜÇÜNCÜ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("İŞKENCE.");
                cmb3.Items.Add("NETİCESİ SEBEBİYLE AĞIRLAŞMIŞ İŞKENCE.");
                cmb3.Items.Add("EZİYET.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 3) //İKİNCİ KISIM - DÖRDÜNCÜ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("TERK.");
                cmb3.Items.Add("YARDIM VEYA BİLDİRİM YÜKÜMLÜLÜĞÜNÜN YERİNE GETİRİLMEMESİ.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 4) //İKİNCİ KISIM - BEŞİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("ÇOCUK DÜŞÜRTME.");
                cmb3.Items.Add("KISIRLAŞTIRMA.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 5) //İKİNCİ KISIM - ALTINCI BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("CİNSEL SALDIRI.");
                cmb3.Items.Add("ÇOCUKLARIN CİNSEL İSTİSMARI.");
                cmb3.Items.Add("REŞİT OLMAYANLA CİNSEL İLİŞKİ.");
                cmb3.Items.Add("CİNSEL TACİZ.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 6) //İKİNCİ KISIM - YEDİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("TEHDİT.");
                cmb3.Items.Add("ŞANTAJ.");
                cmb3.Items.Add("CEBİR.");
                cmb3.Items.Add("KİŞİYİ HÜRRİYETİNDEN YOKSUN KILMA.");
                cmb3.Items.Add("EĞİTİM VE ÖĞRETİMİN ENGELLENMESİ.");
                cmb3.Items.Add("KAMU KURUMU VEYA KAMU KURUMU NİTELİĞİNDEKİ MESLEK KURULUŞLARININ FAALİYETLERİNİN ENGELLENMESİ.");
                cmb3.Items.Add("SİYASÎ HAKLARIN KULLANILMASININ ENGELLENMESİ.");
                cmb3.Items.Add("İNANÇ, DÜŞÜNCE VE KANAAT HÜRRİYETİNİN KULLANILMASINI ENGELLEME.");
                cmb3.Items.Add("KONUT DOKUNULMAZLIĞININ İHLÂLİ.");
                cmb3.Items.Add("İŞ VE ÇALIŞMA HÜRRİYETİNİN İHLÂLİ.");
                cmb3.Items.Add("SENDİKAL HAKLARIN KULLANILMASININ ENGELLENMESİ.");
                cmb3.Items.Add("ORTAK HÜKÜM.");
                cmb3.Items.Add("HAKSIZ ARAMA.");
                cmb3.Items.Add("DİLEKÇE HAKKININ KULLANILMASININ ENGELLENMESİ.");
                cmb3.Items.Add("AYIRIMCILIK.");
                cmb3.Items.Add("KİŞİLERİN HUZUR VE SÜKUNUNU BOZMA.");
                cmb3.Items.Add("HABERLEŞMENİN ENGELLENMESİ.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 7) //İKİNCİ KISIM - SEKİZİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("HAKARET.");
                cmb3.Items.Add("KİŞİNİN HATIRASINA HAKARET.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 8) //İKİNCİ KISIM - DOKUZUNCU BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("HABERLEŞMENİN GİZLİLİĞİNİ İHLÂL.");
                cmb3.Items.Add("KİŞİLER ARASINDAKİ KONUŞMALARIN DİNLENMESİ VE KAYDA ALINMASI.");
                cmb3.Items.Add("ÖZEL HAYATIN GİZLİLİĞİNİ İHLÂL.");
                cmb3.Items.Add("KİŞİSEL VERİLERİN KAYDEDİLMESİ.");
                cmb3.Items.Add("VERİLERİ HUKUKA AYKIRI OLARAK VERME VEYA ELE GEÇİRME.");
                cmb3.Items.Add("VERİLERİ YOK ETMEME.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 9) //İKİNCİ KISIM - ONUNCU BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("HIRZISLIK.");
                cmb3.Items.Add("NİTELİKLİ HIRSIZLIK.");
                cmb3.Items.Add("KULLANMA HIRSIZLIĞI.");
                cmb3.Items.Add("YAĞMA.");
                cmb3.Items.Add("NİTELİKLİ YAĞMA.");
                cmb3.Items.Add("MALA ZARAR VERME.");
                cmb3.Items.Add("İBADETHANELERE VE MEZARLIKLARA ZARAR VERME.");
                cmb3.Items.Add("HAKKI OLMAYAN YERE TECAVÜZ.");
                cmb3.Items.Add("GÜVENİ KÖTÜYE KULLANMA");
                cmb3.Items.Add("BEDELSİZ SENEDİ KULLANMA.");
                cmb3.Items.Add("DOLANDIRICILIK.");
                cmb3.Items.Add("NİTELİKLİ DOLANDIRICILIK.");
                cmb3.Items.Add("HİLELİ İFLÂS.");
                cmb3.Items.Add("TAKSİRLİ İFLÂS.");
                cmb3.Items.Add("KARŞILIKSIZ YARARLANMA.");
                cmb3.Items.Add("ŞİRKET VEYA KOOPERATİFLER HAKKINDA YANLIŞ BİLGİ.");
                cmb3.Items.Add("SUÇ EŞYASININ SATIN ALINMASI VEYA KABUL EDİLMESİ.");
                cmb3.Items.Add("BİLGİ VERMEME.");
            }
            //ÜÇÜNCÜ KISIM.
            else if (cmb1.SelectedIndex == 2 && cmb2.SelectedIndex == 0) //ÜÇÜNCÜ KISIM - BİRİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("GENEL GÜVENLİĞİN KASTEN TEHLİKEYE SOKULMASI.");
                cmb3.Items.Add("GENEL GÜVENLİĞİN TAKSİRLE TEHLİKEYE SOKULMASI.");
                cmb3.Items.Add("RADYASYON YAYMA.");
                cmb3.Items.Add("ATOM ENERJİSİ İLE PATLAMAYA SEBEBİYET VERME.");
                cmb3.Items.Add("TEHLİKELİ MADDELERİN İZİNSİZ OLARAK BULUNDURULMASI VEYA EL DEĞİŞTİRMESİ.");
                cmb3.Items.Add("AKIL HASTASI ÜZERİNDEKİ BAKIM VE GÖZETİM YÜKÜMLÜLÜĞÜNÜN İHLÂLİ.");
                cmb3.Items.Add("İNŞAAT VEYA YIKIMLA İLGİLİ EMNİYET KURALLARINA UYMAMA.");
                cmb3.Items.Add("HAYVANIN TEHLİKE YARATABİLECEK ŞEKİLDE SERBEST BIRAKILMASI.");
                cmb3.Items.Add("İŞARET VE ENGEL KOYMAMA.");
                cmb3.Items.Add("TRAFİK GÜVENLİĞİNİ TEHLİKEYE SOKMA.");
                cmb3.Items.Add("TRAFİK GÜVENLİĞİNİ TAKSİRLE TEHLİKEYE SOKMA.");
            }
            else if (cmb1.SelectedIndex == 2 && cmb2.SelectedIndex == 1) //ÜCÜNCÜ KISIM - İKİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("ÇEVRENİN KASTEN KİRLETİLMESİ.");
                cmb3.Items.Add("ÇEVRENİN TAKSİRLE KİRLETİLMESİ.");
                cmb3.Items.Add("GÜRÜLTÜYE NEDEN OLMA.");
                cmb3.Items.Add("İMAR KİRLİLİĞİNE NEDEN OLMA.");

            }
            else if (cmb1.SelectedIndex == 2 && cmb2.SelectedIndex == 2) //ÜÇÜNCÜ KISIM - ÜÇÜNCÜ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("ZEHİRLİ MADDE KATMA.");
                cmb3.Items.Add("BOZULMUŞ VEYA DEĞİŞTİRİLMİŞ GIDA VEYA İLAÇLARIN TİCARETİ.");
                cmb3.Items.Add("KİŞİLERİN HAYATINI VE SAĞLIĞINI TEHLİKEYE SOKACAK BİÇİMDE İLÂÇ YAPMA VEYA SATMA.");
                cmb3.Items.Add("UYUŞTURUCU VEYA UYARICI MADDE İMAL VE TİCARETİ.");
                cmb3.Items.Add("UYUŞTURUCU VEYA UYARICI MADDE KULLANILMASINI KOLAYLAŞTIRMA.");
                cmb3.Items.Add("KULLANMAK İÇİN UYUŞTURUCU VEYA UYARICI MADDE SATIN ALMAK, KABUL ETMEK VEYA BULUNDURMAK.");
                cmb3.Items.Add("ZEHİRLİ MADDE İMAL VE TİCARETİ.");
                cmb3.Items.Add("SAĞLIK İÇİN TEHLİKELİ MADDE TEMİNİ.");
                cmb3.Items.Add("BULAŞICI HASTALIKLARA İLİŞKİN TEDBİRLERE AYKIRI DAVRANMA.");
                cmb3.Items.Add("USULSÜZ ÖLÜ GÖMÜLMESİ.");
            }
            else if (cmb1.SelectedIndex == 2 && cmb2.SelectedIndex == 3) //ÜÇÜNCÜ KISIM - DÖRDÜNCÜ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("PARADA SAHTECİLİK.");
                cmb3.Items.Add("PARAYA EŞİT SAYILAN DEĞERLER.");
                cmb3.Items.Add("KIYMETLİ DAMGADA SAHTECİLİK.");
                cmb3.Items.Add("PARA VE KIYMETLİ DAMGALARI YAPMAYA YARAYAN ARAÇLAR.");
                cmb3.Items.Add("MÜHÜRDE SAHTECİLİK.");
                cmb3.Items.Add("MÜHÜR BOZMA.");
                cmb3.Items.Add("RESMÎ BELGEDE SAHTECİLİK.");
                cmb3.Items.Add("RESMÎ BELGEYİ BOZMAK, YOK ETMEK VEYA GİZLEMEK");
                cmb3.Items.Add("RESMÎ BELGENİN DÜZENLENMESİNDE YALAN BEYAN");
                cmb3.Items.Add("ÖZEL BELGEDE SAHTECİLİK");
                cmb3.Items.Add("ÖZEL BELGEYİ BOZMAK, YOK ETMEK VEYA GİZLEMEK ");
                cmb3.Items.Add("AÇIĞA İMZANIN KÖTÜYE KULLANILMASI");
            }
            else if (cmb1.SelectedIndex == 2 && cmb2.SelectedIndex == 4) //ÜÇÜNCÜ KISIM - BEŞİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("HALK ARASINDA KORKU VE PANİK YARATMAK AMACIYLA TEHDİT.");
                cmb3.Items.Add("SUÇ İŞLEMEYE TAHRİK.");
                cmb3.Items.Add("SUÇU VE SUÇLUYU ÖVME.");
                cmb3.Items.Add("HALKI KİN VE DÜŞMANLIĞA TAHRİK VEYA AŞAĞILAMA");
                cmb3.Items.Add("KANUNLARA UYMAMAYA TAHRİK ");
                cmb3.Items.Add("GÖREV SIRASINDA DİN HİZMETLERİNİ KÖTÜYE KULLANMA ");
                cmb3.Items.Add("SUÇ İŞLEMEK AMACIYLA ÖRGÜT KURMA ");
                cmb3.Items.Add("ŞAPKA VE TÜRK HARFLERİ ");
            }
            else if (cmb1.SelectedIndex == 2 && cmb2.SelectedIndex == 5) //ÜÇÜNCÜ KISIM - ALTINCI BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("ULAŞIM ARAÇLARININ KAÇIRILMASI VEYA ALIKONULMASI.");
                cmb3.Items.Add("KIT'A SAHANLIĞINDA VEYA MÜNHASIR EKONOMİK BÖLGEDEKİ SABİT PLATFORMLARIN İŞGALİ.");
            }
            else if (cmb1.SelectedIndex == 2 && cmb2.SelectedIndex == 6) //ÜÇÜNCÜ KISIM - YEDİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("HAYASIZCA HAREKETLER.");
                cmb3.Items.Add("MÜSTEHCENLİK.");
                cmb3.Items.Add("FUHUŞ.");
                cmb3.Items.Add("KUMAR OYNANMASI İÇİN YER VE İMKÂN SAĞLAMA.");
                cmb3.Items.Add("DİLENCİLİK.");
            }
            else if (cmb1.SelectedIndex == 2 && cmb2.SelectedIndex == 7) //ÜÇÜNCÜ KISIM - SEKİZİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("BİRDEN ÇOK EVLİLİK, HİLELİ EVLENME, DİNSEL TÖREN");
                cmb3.Items.Add("ÇOCUĞUN SOYBAĞINI DEĞİŞTİRME");
                cmb3.Items.Add("KÖTÜ MUAMELE");
                cmb3.Items.Add("AİLE HUKUKUNDAN KAYNAKLANAN YÜKÜMLÜLÜĞÜN İHLÂLİ");
                cmb3.Items.Add("ÇOCUĞUN KAÇIRILMASI VE ALIKONULMASI ");
            }
            else if (cmb1.SelectedIndex == 2 && cmb2.SelectedIndex == 8) //ÜÇÜNCÜ KISIM - DOKUZUNCU BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("İHALEYE FESAT KARIŞTIRMA ");
                cmb3.Items.Add("EDİMİN İFASINA FESAT KARIŞTIRMA ");
                cmb3.Items.Add("FİYATLARI ETKİLEME ");
                cmb3.Items.Add("KAMUYA GEREKLİ ŞEYLERİN YOKLUĞUNA NEDEN OLMA");
                cmb3.Items.Add("TİCARÎ SIR, BANKACILIK SIRRI VEYA MÜŞTERİ SIRRI NİTELİĞİNDEKİ BİLGİ VEYA BELGELERİN AÇIKLANMASI");
                cmb3.Items.Add("MAL VEYA HİZMET SATIMINDAN KAÇINMA");
                cmb3.Items.Add("TEFECİLİK");
            }
            else if (cmb1.SelectedIndex == 2 && cmb2.SelectedIndex == 9) //ÜÇÜNCÜ KISIM - ONUNCU BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("BİLİŞİM SİSTEMİNE GİRME ");
                cmb3.Items.Add("SİSTEMİ ENGELLEME, BOZMA, VERİLERİ YOK ETME VEYA DEĞİŞTİRME");
                cmb3.Items.Add("BANKA VEYA KREDİ KARTLARININ KÖTÜYE KULLANILMASI");
            }
            else if (cmb1.SelectedIndex == 3 && cmb2.SelectedIndex == 0) //DÖRDÜNCÜ KISIM - BİRİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("ZİMMET");
                cmb3.Items.Add("İRTİKÂP");
                cmb3.Items.Add("DENETİM GÖREVİNİN İHMALİ");
                cmb3.Items.Add("RÜŞVET");
                cmb3.Items.Add("YETKİLİ OLMADIĞI BİR İŞ İÇİN YARAR SAĞLAMA");
                cmb3.Items.Add("ZOR KULLANMA YETKİSİNE İLİŞKİN SINIRIN AŞILMASI");
                cmb3.Items.Add("GÖREVİ KÖTÜYE KULLANMA");
                cmb3.Items.Add("GÖREVE İLİŞKİN SIRRIN AÇIKLANMASI");
                cmb3.Items.Add("KAMU GÖREVLİSİNİN TİCARETİ");
                cmb3.Items.Add("KAMU GÖREVİNİN TERKİ VEYA YAPILMAMASI");
                cmb3.Items.Add("KİŞİLERİN MALLARI ÜZERİNDE USULSÜZ TASARRUF");
                cmb3.Items.Add("KAMU GÖREVİNİN USULSÜZ OLARAK ÜSTLENİLMESİ");
                cmb3.Items.Add("KANUNA AYKIRI EĞİTİM KURUMU ");
                cmb3.Items.Add("ÖZEL İŞARET VE KIYAFETLERİ USULSÜZ KULLANMA");
                cmb3.Items.Add("GÖREVİ YAPTIRMAMAK İÇİN DİRENME");
                cmb3.Items.Add("KAMU GÖREVİNE AİT ARAÇ VE GEREÇLERİ SUÇTA KULLANMA");
            }
            else if (cmb1.SelectedIndex == 3 && cmb2.SelectedIndex == 1) //DÖRDÜNCÜ KISIM - İKİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("İFTİRA");
                cmb3.Items.Add("BAŞKASINA AİT KİMLİK VEYA KİMLİK BİLGİLERİNİN KULLANILMASI");
                cmb3.Items.Add("SUÇ ÜSTLENME");
                cmb3.Items.Add("SUÇ UYDURMA");
                cmb3.Items.Add("YALAN TANIKLIK");
                cmb3.Items.Add("YALAN YERE YEMİN ");
                cmb3.Items.Add("GERÇEĞE AYKIRI BİLİRKİŞİLİK VEYA TERCÜMANLIK ");
                cmb3.Items.Add("YARGI GÖREVİ YAPANI ETKİLEME ");
                cmb3.Items.Add("SUÇU BİLDİRMEME");
                cmb3.Items.Add("SAĞLIK MESLEĞİ MENSUPLARININ SUÇU BİLDİRMEMESİ");
                cmb3.Items.Add("SUÇ DELİLLERİNİ YOK ETME, GİZLEME VEYA DEĞİŞTİRME ");
                cmb3.Items.Add("SUÇTAN KAYNAKLANAN MALVARLIĞI DEĞERLERİNİ AKLAMA ");
                cmb3.Items.Add("SUÇLUYU KAYIRMA");
                cmb3.Items.Add("TUTUKLU, HÜKÜMLÜ VEYA SUÇ DELİLLERİNİ BİLDİRMEME ");
                cmb3.Items.Add("GİZLİLİĞİN İHLÂLİ");
                cmb3.Items.Add("SES VEYA GÖRÜNTÜLERİN KAYDA ALINMASI");
                cmb3.Items.Add("GENİTAL MUAYENE");
                cmb3.Items.Add("ADİL YARGILAMAYI ETKİLEMEYE TEŞEBBÜS");
                cmb3.Items.Add("MUHAFAZA GÖREVİNİ KÖTÜYE KULLANMA");
                cmb3.Items.Add("RESMEN TESLİM OLUNAN MALA ELKONULMASI VE BOZULMASI");
                cmb3.Items.Add("BAŞKASI YERİNE CEZA İNFAZ KURUMUNA VEYA TUTUKEVİNE GİRME");
                cmb3.Items.Add("HÜKÜMLÜ VEYA TUTUKLUNUN KAÇMASI");
                cmb3.Items.Add("KAÇMAYA İMKÂN SAĞLAMA");
                cmb3.Items.Add("MUHAFIZIN GÖREVİNİ KÖTÜYE KULLANMASI");
                cmb3.Items.Add("HÜKÜMLÜ VEYA TUTUKLULARIN AYAKLANMASI");
                cmb3.Items.Add("İNFAZ KURUMUNA VEYA TUTUKEVİNE YASAK EŞYA SOKMAK");
                cmb3.Items.Add("HAK KULLANIMINI VE BESLENMEYİ ENGELLEME");
            }
            else if (cmb1.SelectedIndex == 3 && cmb2.SelectedIndex == 2) //DÖRDÜNCÜ KISIM - ÜÇÜNCÜ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("CUMHURBAŞKANINA HAKARET ");
                cmb3.Items.Add("DEVLETİN EGEMENLİK ALAMETLERİNİ AŞAĞILAMA");
                cmb3.Items.Add("TÜRK MİLLETİNİ, TÜRKİYE CUMHURİYETİ DEVLETİNİ, DEVLETİN KURUM VE ORGANLARINI AŞAĞILAMA");
            }
            else if (cmb1.SelectedIndex == 3 && cmb2.SelectedIndex == 3) //DÖRDÜNCÜ KISIM - DÖRDÜNCÜ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("DEVLETİN BİRLİĞİNİ VE ÜLKE BÜTÜNLÜĞÜNÜ BOZMAK");
                cmb3.Items.Add("DÜŞMANLA İŞBİRLİĞİ YAPMAK");
                cmb3.Items.Add("DEVLETE KARŞI SAVAŞA TAHRİK");
                cmb3.Items.Add("TEMEL MİLLİ YARARLARA KARŞI FAALİYETTE BULUNMAK İÇİN YARAR SAĞLAMA");
                cmb3.Items.Add("YABANCI DEVLET ALEYHİNE ASKER TOPLAMA");
                cmb3.Items.Add("ASKERÎ TESİSLERİ TAHRİP VE DÜŞMAN ASKERÎ HAREKETLERİ YARARINA ANLAŞMA");
                cmb3.Items.Add("DÜŞMAN DEVLETE MADDÎ VE MALÎ YARDIM");
            }
            else if (cmb1.SelectedIndex == 3 && cmb2.SelectedIndex == 4) //DÖRDÜNCÜ KISIM - BEŞİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("ANAYASAYI İHLÂL");
                cmb3.Items.Add("CUMHURBAŞKANINA SUİKAST VE FİİLÎ SALDIRI");
                cmb3.Items.Add("YASAMA ORGANINA KARŞI SUÇ");
                cmb3.Items.Add("HÜKÛMETE KARŞI SUÇ");
                cmb3.Items.Add("TÜRKİYE CUMHURİYETİ HÜKÛMETİNE KARŞI SİLÂHLI İSYAN");
                cmb3.Items.Add("SİLAHLI ÖRGÜT");
                cmb3.Items.Add("SİLAH SAĞLAMA");
                cmb3.Items.Add("SUÇ İÇİN ANLAŞMA");
            }
            else if (cmb1.SelectedIndex == 3 && cmb2.SelectedIndex == 5) //DÖRDÜNCÜ KISIM - ALTINCI BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("ASKERÎ KOMUTANLIKLARIN GASBI");
                cmb3.Items.Add("HALKI ASKERLİKTEN SOĞUTMA");
                cmb3.Items.Add("ASKERLERİ İTAATSİZLİĞE TEŞVİK");
                cmb3.Items.Add("YABANCI HİZMETİNE ASKER YAZMA, YAZILMA");
                cmb3.Items.Add("SAVAŞ ZAMANINDA EMİRLERE UYMAMA");
                cmb3.Items.Add("SAVAŞ ZAMANINDA YÜKÜMLÜLÜKLER ");
                cmb3.Items.Add("SAVAŞTA YALAN HABER YAYMA ");
                cmb3.Items.Add("SEFERBERLİKLE İLGİLİ GÖREVİN İHMALİ");
                cmb3.Items.Add("DÜŞMANDAN UNVAN VE BENZERİ PAYELER KABULÜ");
            }
            else if (cmb1.SelectedIndex == 3 && cmb2.SelectedIndex == 6) //DÖRDÜNCÜ KISIM - YEDİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("DEVLETİN GÜVENLİĞİNE İLİŞKİN BELGELER");
                cmb3.Items.Add("DEVLETİN GÜVENLİĞİNE İLİŞKİN BİLGİLERİ TEMİN ETME");
                cmb3.Items.Add("SİYASAL VEYA ASKERÎ CASUSLUK");
                cmb3.Items.Add("DEVLETİN GÜVENLİĞİNE VE SİYASAL YARARLARINA İLİŞKİN BİLGİLERİ AÇIKLAMA");
                cmb3.Items.Add("GİZLİ KALMASI GEREKEN BİLGİLERİ AÇIKLAMA");
                cmb3.Items.Add("ULUSLARARASI CASUSLUK");
                cmb3.Items.Add("ASKERÎ YASAK BÖLGELERE GİRME");
                cmb3.Items.Add("DEVLET SIRLARINDAN YARARLANMA, DEVLET HİZMETLERİNDE SADAKATSİZLİK");
                cmb3.Items.Add("YASAKLANAN BİLGİLERİ TEMİN");
                cmb3.Items.Add("YASAKLANAN BİLGİLERİN CASUSLUK MAKSADIYLA TEMİNİ");
                cmb3.Items.Add("YASAKLANAN BİLGİLERİ AÇIKLAMA");
                cmb3.Items.Add("YASAKLANAN BİLGİLERİ SİYASAL VEYA ASKERÎ CASUSLUK MAKSADIYLA AÇIKLAMA");
                cmb3.Items.Add("TAKSİR SONUCU CASUSLUK FİİLLERİNİN İŞLENMESİ");
                cmb3.Items.Add("DEVLET GÜVENLİĞİ İLE İLGİLİ BELGELERİ ELİNDE BULUNDURMA");
            }
            else if (cmb1.SelectedIndex == 3 && cmb2.SelectedIndex == 7) //DÖRDÜNCÜ KISIM - SEKİZİNCİ BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("YABANCI DEVLET BAŞKANINA KARŞI SUÇ");
                cmb3.Items.Add("YABANCI DEVLET BAYRAĞINA KARŞI HAKARET");
                cmb3.Items.Add("YABANCI DEVLET TEMSİLCİLERİNE KARŞI SUÇ");
            }
            else if (cmb1.SelectedIndex == 3 && cmb2.SelectedIndex == 8) //DÖRDÜNCÜ KISIM - DOKUZUNCU BÖLÜM
            {
                cmb3.Items.Clear();
                cmb3.Items.Add("YÜRÜRLÜK");
                cmb3.Items.Add("YÜRÜTME");
            }
        }
        private void cmb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1.SelectedIndex != -1 && cmb2.SelectedIndex != -1 && cmb3.SelectedIndex != -1) btn_AddCrime.Enabled = true;
            cmb4.Text = "";
            if (cmb1.SelectedIndex == 0 && cmb2.SelectedIndex == 0 && cmb3.SelectedIndex == 0) // 1.KISIM 1.BÖLÜM - SOYKIRIM
            {
                Warning();
                cmb4.Enabled = true;
                cmb4.Items.Clear();
                cmb4.Items.Add("a) Kasten öldürme.");
                cmb4.Items.Add("b) Kişilerin bedensel veya ruhsal bütünlüklerine ağır zarar verme.");
                cmb4.Items.Add("c) Grubun, tamamen veya kısmen yokedilmesi sonucunu doğuracak koşullarda yaşamaya zorlanması.");
                cmb4.Items.Add("d) Grup içinde doğumlara engel olmaya yönelik tedbirlerin alınması.");
                cmb4.Items.Add("e) Gruba ait çocukların bir başka gruba zorla nakledilmesi.");
            }
            else if (cmb1.SelectedIndex == 0 && cmb2.SelectedIndex == 0 && cmb3.SelectedIndex == 1) // 1.KISIM 1.BÖLÜM - İNSANLIĞA KARŞI SUÇLAR
            {
                Warning();
                cmb4.Enabled = true;
                cmb4.Items.Clear();
                cmb4.Items.Add("a) Kasten öldürme.");
                cmb4.Items.Add("b) Kişilerin bedensel veya ruhsal bütünlüklerine ağır zarar verme.");
                cmb4.Items.Add("c) Grubun, tamamen veya kısmen yokedilmesi sonucunu doğuracak koşullarda yaşamaya zorlanması.");
                cmb4.Items.Add("d) Grup içinde doğumlara engel olmaya yönelik tedbirlerin alınması.");
                cmb4.Items.Add("e) Gruba ait çocukların bir başka gruba zorla nakledilmesi.");
            }
            else if (cmb1.SelectedIndex == 0 && cmb2.SelectedIndex == 1 && cmb3.SelectedIndex == 0) // 1.KISIM 2.BÖLÜM - GÖÇMEN KAÇAKÇILIĞI
            {
                cmb4.Enabled = true;
                cmb4.Items.Clear();
                cmb4.Items.Add("a) Bir yabancıyı ülkeye sokan veya ülkede kalmasına imkân sağlayan, ");
                cmb4.Items.Add("b) Türk vatandaşı veya yabancının yurt dışına çıkmasına imkân sağlayan, ");
            }
            else if (cmb1.SelectedIndex == 0 && cmb2.SelectedIndex == 1 && cmb3.SelectedIndex == 1) // 1.KISIM 2.BÖLÜM -  İNSAN TİCARETİ
            {
                cmb4.Enabled = true;
                cmb4.Items.Clear();
                cmb4.Items.Add("a) Zorla çalıştırmak.");
                cmb4.Items.Add("b) Hizmet ettirmek.");
                cmb4.Items.Add("c) Fuhuş yaptırmak.");
                cmb4.Items.Add("d) Esarete tabi kılmak.");
                cmb4.Items.Add("e) Vücut organlarının verilmesini sağlamak");
            }
            //2.KISIM
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 0 && cmb3.SelectedIndex == 0) // 2.KISIM 1.BÖLÜM -  KASTEN ÖLDÜRME
            {
                cmb4.Enabled = true;
                cmb4.Items.Clear();
                cmb4.Items.Add("a) Tasarlayarak.");
                cmb4.Items.Add("b) Canavarca hisle veya eziyet çektirerek.");
                cmb4.Items.Add("c) Yangın, su baskını, tahrip, batırma veya bombalama ya da nükleer, biyolojik veya kimyasal silâh kullanmak suretiyle.");
                cmb4.Items.Add("d) Üstsoy veya altsoydan birine ya da eş veya kardeşe karşı.");
                cmb4.Items.Add("e) Çocuğa ya da beden veya ruh bakımından kendisini savunamayacak durumda bulunan kişiye karşı.");
                cmb4.Items.Add("f) Gebe olduğu bilinen kadına karşı.");
                cmb4.Items.Add("g) Kişinin yerine getirdiği kamu görevi nedeniyle.");
                cmb4.Items.Add("h) Bir suçu gizlemek, delillerini ortadan kaldırmak veya işlenmesini kolaylaştırmak ya da yakalanmamak amacıyla.");
                cmb4.Items.Add("i) Bir suçu işleyememekten dolayı duyduğu infialle");
                cmb4.Items.Add("j) Kan gütme saikiyle.");
                cmb4.Items.Add("k) Töre saikiyle.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 0 && cmb3.SelectedIndex == 1) // 2.KISIM 1.BÖLÜM -  KASTEN ÖLDÜRMENİN İHMALİ DAVRANIŞLA İŞLENMESİ 
            {
                cmb4.Enabled = true;
                cmb4.Items.Clear();
                cmb4.Items.Add("a) Kişinin yükümlü olduğu bir icrai davranışı gerçekleştirmemesi ile meydana gelen ölüm neticesi");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 0 && cmb3.SelectedIndex == 1) // 2.KISIM 1.BÖLÜM -  İNTİHARA YÖNLENDİRME 
            {
                cmb4.Enabled = true;
                cmb4.Items.Clear();
                cmb4.Items.Add("a) İntihara azmettirme");
                cmb4.Items.Add("b) İntihara teşvik etme");
                cmb4.Items.Add("c) Başkalarının intihar kararını kuvvetlendiren.");
                cmb4.Items.Add("d) Başkasının intiharına yardım eden");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 0 && cmb3.SelectedIndex == 1) // 2.KISIM 1.BÖLÜM - TAKSİRLE ÖLDÜRME
            {
                cmb4.Enabled = true;
                cmb4.Items.Clear();
                cmb4.Items.Add("a) Taksirle(kusur ile) bir insanın ölümüne neden olma.");
            }
            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 1 && cmb3.SelectedIndex == 1) // 2.KISIM 2.BÖLÜM - KASTEN YARALAMA 
            {
                cmb4.Enabled = true;
                cmb4.Items.Clear();
                cmb4.Items.Add("a) Üstsoya, altsoya, eşe veya kardeşe karş.");
                cmb4.Items.Add("b) Beden veya ruh bakımından kendisini savunamayacak durumda bulunan kişiye karşı.");
                cmb4.Items.Add("c) Kişinin yerine getirdiği kamu görevi nedeniyle, ");
                cmb4.Items.Add("d) Kamu görevlisinin sahip bulunduğu nüfuz kötüye kullanılmak suretiyle.");
                cmb4.Items.Add("e) Silâhla");
            }

            else if (cmb1.SelectedIndex == 1 && cmb2.SelectedIndex == 1 && cmb3.SelectedIndex == 1) // 2.KISIM 2.BÖLÜM - NETİCESİ SEBEBİYLE AĞIRLAŞMIŞ YARALAMA 
            {
                //BU MADDEYE DİKKAT***
            }
        }

        private void btn_SelectedCrime_Click(object sender, EventArgs e)
        {
            if (lst_Crime.SelectedIndex == 0)
            {
                Suc1 = "Bos";
                label4.Text = Suc1;
                lst_Crime.Items.Remove(lst_Crime.SelectedItem);
            }
            else if (lst_Crime.SelectedIndex == 1)
            {
                Suc2 = "Bos";
                label14.Text = Suc2;
                lst_Crime.Items.Remove(lst_Crime.SelectedItem);
            }
        }
        private void btn_AllCrime_Click(object sender, EventArgs e)
        {
            lst_Crime.Items.Clear();
            Suc1 = "Bos";
            Suc2 = "Bos";
            label4.Text = Suc1;
            label14.Text = Suc2;
        }
        private void btn_ShowPunishment_Click(object sender, EventArgs e)
        {
            if (lst_Crime.Items.Count != 0) //İÇİNDE HERHANGİ İTEM VARMI?
            {
                Crime1 = lst_Crime.Items[0].ToString();
                if (lst_Crime.Items.Count == 2) Crime2 = lst_Crime.Items[1].ToString();
                else Crime2 = "";
                this.Hide();
                newfrm.Show();
            }
            else
            {
                MessageBox.Show("Kayıtlı öge yok!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "bbbb";
            txt_LastName.Text = "bbbbb";
            cmb_Graduation.SelectedIndex = 1;
            cmb_Job.SelectedIndex = 1;
            cmb_Nationality.SelectedIndex = 1;
            cmb1.SelectedIndex = 0;
            cmb2.SelectedIndex = 0;
            cmb3.SelectedIndex = 0;
        }
    }
}


