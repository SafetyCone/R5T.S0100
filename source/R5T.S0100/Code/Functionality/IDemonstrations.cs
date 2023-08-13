using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0031.Extensions;
using R5T.L0038;
using R5T.T0132;
using R5T.T0198;


namespace R5T.S0100
{
    [FunctionalityMarker]
    public partial interface IDemonstrations : IFunctionalityMarker
    {
        public async Task In_SampleProjectFileContext()
        {
            /// Inputs.
            // Required since project file contains package values.
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var repositoryUrl = new IsSet<IRepositoryUrl>();


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.SampleProjectFileOperations.In_New_SampleProjectFileContext(
                    applicationContext.TextOutput,
                    async projectFileContext =>
                    {
                        await projectFileContext.Run(
                            Instances.ProjectFileContextOperations.Setup_RazorClassLibraryProjectFile(
                                projectDescription,
                                repositoryUrl
                            )
                        );

                        // Open the project file.
                        Instances.NotepadPlusPlusOperator.Open(projectFileContext.ProjectFilePath.Value);
                    });
            }
        }

        public async Task Create_SampleRazorClassLibraryProjectFile()
        {
            /// Inputs.
            var projectName = Instances.Values.Sample_ProjectName;
            var projectFilePath = Instances.FilePaths.Sample_ProjectFilePath;
            // Required since project file contains package values.
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var repositoryUrl = new IsSet<IRepositoryUrl>();


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                // Make sure the sample project file does not exist.
                Instances.FileSystemOperator.DeleteFile_OkIfNotExists(
                    projectFilePath.Value);

                await Instances.ProjectFileContextOperator.In_New_ProjectFileContext(
                    projectName,
                    projectFilePath,
                    applicationContext.TextOutput,
                    Instances.ProjectFileContextOperations.Setup_RazorClassLibraryProjectFile(
                        projectDescription,
                        repositoryUrl
                    )
                );
            }

            // Open the project file.
            Instances.NotepadPlusPlusOperator.Open(projectFilePath.Value);
        }
    }
}
