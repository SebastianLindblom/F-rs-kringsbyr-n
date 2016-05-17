using System.Windows.Forms;

namespace Försäkringsbyrån
{
    public class MessageBoxesClass
    {
        public static void SparaSuccesfull(string Objekt)
        {
            MessageBox.Show(Objekt + " är nu sparad", "",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void SparaError(string Objekt)
        {
            MessageBox.Show(Objekt + " Var vänlig försök igen eller kontakta IT-Support", "Det gick inte att spara",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void BorttagningSuccesfull(string Objekt)
        {
            MessageBox.Show(Objekt + " Har tagits bort", "",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void BorttagningError(string Objekt)
        {
            MessageBox.Show(Objekt + " Var vänlig försök igen eller kontakta IT-Support", "Det gick inte att ta bort " + Objekt,
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void InloggningError()
        {
            MessageBox.Show("Var vänlig försök igen eller kontakta IT-Support", "Användarnamn eller lösenord matchade inte",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void HittadeInte(string v)
        {
            MessageBox.Show("Var vänlig försök med en annan sökning", v + " hittades inte",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Handlingskontroll(string Handling)
        {
            return ((MessageBox.Show("Är du säker att du vill " + Handling, "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes));
        }
        public static DialogResult Hittade(string v)
        {
            return MessageBox.Show("Vill du spara över den?", "Försäkring med löpnummer " + v + " hittades",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static DialogResult FinnsRedan(string v)
        {
            return MessageBox.Show(v + "finns redan", "Finns redan",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal static void Error(string message)
        {
            MessageBox.Show(message + " - Kontakta IT-Support", "Nu gick det snett",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void AnkomstårInteIfylld(string v)
        {
            MessageBox.Show("Fyll i rutan - " + v + ", för att få fram beloppen", v + " inte ifylld",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
