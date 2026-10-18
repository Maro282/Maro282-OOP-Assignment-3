namespace RefactoringLab.Part02.Reports;

public class TextReportExporter : ReportTemplateMethod
{

    public override string Format(List<string[]> rows) =>
        string.Join(Environment.NewLine, rows.Select(r => string.Join(" | ", r)));

}
