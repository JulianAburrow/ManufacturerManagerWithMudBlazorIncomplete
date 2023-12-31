﻿namespace ManufacturerManagerUserInterface.Features.Colours;

public partial class Delete
{
    protected override async Task OnInitializedAsync() =>
        ColourModel = await ColourHandler.GetColourAsync(ColourId);

    private async Task DeleteColour()
    {
        try
        {
            await ColourHandler.DeleteColourAsync(ColourId, true);
            Snackbar.Add($"Colour {ColourModel.Name} successfully deleted", Severity.Success);
            NavigationManager.NavigateTo("/colours/index");
        }
        catch
        {
            Snackbar.Add($"An error occurred deleting Colour {ColourModel.Name}. Please try again", Severity.Error);
        }
    }
}
