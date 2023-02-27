using Syncfusion.Maui.DataForm;

namespace MinMaxDateEditor;

public class DataFormBehavior : Behavior<SfDataForm>
{
    protected override void OnAttachedTo(SfDataForm dataForm)
    {
        base.OnAttachedTo(dataForm);
        dataForm.RegisterEditor("AppointmentDate", DataFormEditorType.Date);
        dataForm.RegisterEditor("AppointmentTime", DataFormEditorType.Time);
        dataForm.GenerateDataFormItem += OnGenerateDataItem;
    }

    private void OnGenerateDataItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null && e.DataFormItem is DataFormDateItem dateItem)
        {
            dateItem.MinimumDisplayDate = new DateTime(2022, 12, 05);
            dateItem.MaximumDisplayDate = new DateTime(2022, 12, 25);
        }
    }
}
