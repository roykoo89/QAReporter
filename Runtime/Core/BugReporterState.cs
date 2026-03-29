namespace QAReporter.Core
{
    /// <summary>
    /// States for the bug reporter workflow state machine.
    /// </summary>
    public enum BugReporterState
    {
        Idle,
        Recording,
        Review,
        Sending,
        Complete,
        Error
    }
}
