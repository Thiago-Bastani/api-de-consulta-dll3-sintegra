
using System.Runtime.InteropServices;

internal class DllHandler
{

    [DllImport("DllInscE32.dll")]
    public static extern int ConsisteInscricaoEstadual(string vInsc, string vUF);

}