using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores",
        Justification = "Not applicable for test names", Scope = "module")]
[assembly:
    SuppressMessage("Naming", "IDE0058:Expression value is never used",
        Justification = "Not applicable for demo app", Scope = "module")]