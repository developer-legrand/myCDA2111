using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.EventLib
{
    public static class TreeManager
    {
        public static void DisplayTreeNode(FolderBrowserDialog fbd, TreeView tree, TextBox txt)
        {
            tree.Nodes.Clear();
            fbd = new FolderBrowserDialog(); 
            if (fbd.ShowDialog() != DialogResult.OK) { return; }
            tree.BeginUpdate();
            tree.Nodes.Add(SelectDirectory(fbd.SelectedPath));
            txt.Text = fbd.SelectedPath;
            tree.EndUpdate();
        }
        private  static TreeNode SelectDirectory(string path)
        {
            TreeNode result = new TreeNode(Path.GetFileName(path));
            foreach (var files in Directory.GetFiles(path))
            { 
                result.Nodes.Add(Path.GetFileName(files));
                /*result.SelectedImageIndex = 1;*/ 
            }
            foreach (var subdirectory in Directory.GetDirectories(path))
            {           
                result.Nodes.Add(SelectDirectory(subdirectory)); 
            }
            return result;
        }

        public static void InputDirectory(TextBox input, TreeView tree)
        {
            tree.Nodes.Add(SelectDirectory(input.Text));
        }
    }  
}
