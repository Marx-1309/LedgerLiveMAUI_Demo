using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Linq;

namespace LedgerDemo
{
    public partial class SetupPage : ContentPage
    {
        private List<View> modalSteps;
        private int currentStepIndex = 0;

        public SetupPage()
        {
            InitializeComponent();
            modalSteps = ModalContent.Children.OfType<View>().ToList();
            UpdateModalContent();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        private void OnReadyClicked(object sender, EventArgs e)
        {
            ModalFrame.IsVisible = true;
            currentStepIndex = 0;
            UpdateModalContent();
        }

        private void OnNextStepClicked(object sender, EventArgs e)
        {
            if (currentStepIndex < modalSteps.Count - 1)
            {
                currentStepIndex++;
                UpdateModalContent();
            }
        }

        private void OnPreviousStepClicked(object sender, EventArgs e)
        {
            if (currentStepIndex > 0)
            {
                currentStepIndex--;
                UpdateModalContent();
            }
        }

        private void OnModalCloseClicked(object sender, EventArgs e)
        {
            ModalFrame.IsVisible = false;
        }

        private void UpdateModalContent()
        {
            foreach (var step in modalSteps)
            {
                step.IsVisible = false;
            }
            if (currentStepIndex >= 0 && currentStepIndex < modalSteps.Count)
            {
                modalSteps[currentStepIndex].IsVisible = true;
            }
        }
    }
}