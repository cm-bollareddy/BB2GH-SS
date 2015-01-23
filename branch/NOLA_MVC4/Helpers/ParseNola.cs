using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace NOLA_MVC4.Helpers
{
    public class ParseNola
    {
        private int MAX_NOLA_LEN = 14;
        private int MAX_ROOT_LEN = 6;
        private int MAX_EPISODE_LEN = 6;
        private int BLANK = 32;

        public bool util_validate_nola_root(string sNolaRoot, ref string sFormattedRoot, ref string sStatusMessage)
        {
            bool bGoodRoot = true;
            int i = 0;
            StringBuilder sbRoot = new StringBuilder();

            sbRoot.Length = 0;
            sFormattedRoot = null;
            sStatusMessage = null;

            if (sNolaRoot.Length > MAX_ROOT_LEN)
            {
                bGoodRoot = false;
                sStatusMessage = "Nola root is too long.";
            }
            else if (sNolaRoot.Length < 1)
            {
                bGoodRoot = false;
                sStatusMessage = "Missing nola root.";
            }
            else
            {
                while (i < MAX_ROOT_LEN && i < sNolaRoot.Length && bGoodRoot == true)
                {
                    if ((Char.IsLetter(sNolaRoot[i])) || (sNolaRoot[i] == BLANK))
                    {
                        if (Char.IsLetter(sNolaRoot[i]))
                        {
                            sbRoot.Append(sNolaRoot[i]);
                        } // endif
                        i++;
                    }
                    else
                    {
                        bGoodRoot = false;
                        sStatusMessage = "Invalid nola root.";
                    } // endif
                } // end while-loop
            } // endif

            if (bGoodRoot)
            {
                sFormattedRoot = sbRoot.ToString().PadRight(6, ' ').ToUpper();
            } // endif

            return bGoodRoot;
        } // end util_validate_nola_root method

        public bool Util_Parse_Nola(string sNolaCode, ref string sFormattedNolaCode, ref string sStatusMessage)
        {
            bool bOK = false;
            string sRoot = null;
            string sEpisode = null;
            string sSubscript = null;

            sFormattedNolaCode = null;
            sStatusMessage = null;

            bOK = ParseNolaString(sNolaCode, ref sRoot, ref sEpisode, ref sSubscript, ref sStatusMessage);

            if (bOK)
            {
                sFormattedNolaCode = sRoot + sEpisode + sSubscript;
            } // endif
            return bOK;
        } // end Util_Parse_Nola method, overload 2

        private bool ParseNolaString(string sNolaCode, ref string sRoot, ref string sEpisode, ref string sSubscript, ref string sStatusMessage)
        {
            int i = 0;
            int j = 0;
            bool bGoodNola = true;
            StringBuilder sbRoot = new StringBuilder();
            StringBuilder sbEpisode = new StringBuilder();
            StringBuilder sbSubscript = new StringBuilder();

            sRoot = null;
            sEpisode = null;
            sSubscript = null;
            sStatusMessage = null;
            sbRoot.Length = 0;
            sbEpisode.Length = 0;
            sbSubscript.Length = 0;

            if (sNolaCode.Length > MAX_NOLA_LEN)
            {
                sStatusMessage = "Nola Code cannot exceed " + MAX_NOLA_LEN.ToString() + " bytes in length.";
                bGoodNola = false;
                return bGoodNola;
            }
            else if ((sNolaCode == null) || (sNolaCode.Length < 1))
            {
                sStatusMessage = "Nola code is empty!";
                bGoodNola = false;
                return bGoodNola;
            } // endif

            bGoodNola = false;
            i = 0;


            if (Char.IsLetter(sNolaCode[0]) == true)
            {
                bGoodNola = true;
            }
            else
            {
                bGoodNola = false;
                sStatusMessage = "Missing nola root.";
                return bGoodNola;
            } // endif

            j = -1;
            bGoodNola = false;

            /* Extract the root. */

            while ((i < sNolaCode.Length) && (j < MAX_ROOT_LEN) && bGoodNola == false)
            {
                if (Char.IsLetter(sNolaCode[i]) == true)
                {
                    j++;
                    sbRoot.Append(sNolaCode[i]);
                    i++;
                }
                else
                {
                    bGoodNola = true;
                } // endif
            } // end while-loop

            if (!bGoodNola)
            {
                sStatusMessage = "Invalid nola root.";
                return bGoodNola;
            } // endif

            bGoodNola = false;

            while (i < sNolaCode.Length && bGoodNola == false)
            {
                if (Char.IsDigit(sNolaCode[i]) == true)
                {
                    bGoodNola = true;
                }
                else
                {
                    i++;
                } // endif
            } // end while-loop

            if (!bGoodNola)
            {
                sStatusMessage = "Missing nola episode number.";
                return bGoodNola;
            } // endif

            /* Extract the episode. */

            while ((i < sNolaCode.Length) && (Char.IsDigit(sNolaCode[i]) == true))
            {
                sbEpisode.Append(sNolaCode[i]);
                i++;
            } // end while-loop

            if (sbEpisode.Length > MAX_EPISODE_LEN)
            {
                bGoodNola = false;
                sStatusMessage = "Nola episode too long.";
                return bGoodNola;
            } // endif

            bGoodNola = false;

            /* Find where the subscript begins, if it exists. */

            while (i < sNolaCode.Length && bGoodNola == false)
            {
                if (Char.IsLetter(sNolaCode[i]) == true)
                {
                    bGoodNola = true;
                }
                else
                {
                    i++;
                } // endif
            } // end while-loop

            if (bGoodNola)
            {
                /* There is a subscript.  It must begin with an alpha character,
                ** and optionally a second alphanumeric character may follow. */

                sbSubscript.Append(sNolaCode[i]); /* Grab the first character (must be alpha). */

                /* If the following character is alphanumeric, include that, too. */
                /* If not, the subscript is only one character, and we already have it. */

                if ((i + 1 < sNolaCode.Length) &&
                        ((Char.IsLetter(sNolaCode[i + 1]) == true) || (Char.IsDigit(sNolaCode[i + 1]) == true)))
                {
                    sbSubscript.Append(sNolaCode[i + 1]);
                } /* endif */
            } // endif

            bGoodNola = true;

            sRoot = sbRoot.ToString().PadRight(6, ' ').ToUpper();
            sEpisode = sbEpisode.ToString().PadLeft(6, '0');
            sSubscript = sbSubscript.ToString().PadRight(2, ' ').ToUpper();

            return bGoodNola;

        } // end ParseNola method
    }
}