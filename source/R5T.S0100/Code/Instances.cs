using System;


namespace R5T.S0100
{
    public static class Instances
    {
        public static L0038.IApplicationContextOperator ApplicationContextOperator => L0038.ApplicationContextOperator.Instance;
        public static Z0046.IFilePaths FilePaths => Z0046.FilePaths.Instance;
        public static F0000.IFileSystemOperator FileSystemOperator => F0000.FileSystemOperator.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static L0033.IProjectFileContextOperations ProjectFileContextOperations => L0033.ProjectFileContextOperations.Instance;
        public static L0033.IProjectFileContextOperator ProjectFileContextOperator => L0033.ProjectFileContextOperator.Instance;
        public static O0006.O001.ISampleProjectFileOperations SampleProjectFileOperations => O0006.O001.SampleProjectFileOperations.Instance; 
        public static IValues Values => S0100.Values.Instance;
    }
}