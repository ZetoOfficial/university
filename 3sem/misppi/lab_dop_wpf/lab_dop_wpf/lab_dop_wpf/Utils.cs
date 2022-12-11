using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_dop_wpf;

public class Utils
{
    public bool ValidateInput(string text, char newChar)
    {
        // if newChar is backspace
        if (newChar == (char)8) return true;
        // if newChar is number
        if (Char.IsDigit(newChar)) return true;
        // if newChar is munis | can only be one minus in text
        if (newChar == '-' && !text.Contains('-')) return true;
        // if newChar is comma (',') | can only be one comma in text
        if (newChar == ',' && !text.Contains('-')) return true;
        // Check 0 count in first part | example: 0000,1 -> bad
        // if (newChar == '0' && !text.Split(',')[0].Contains('0')) return true;
        return false;
    }
}