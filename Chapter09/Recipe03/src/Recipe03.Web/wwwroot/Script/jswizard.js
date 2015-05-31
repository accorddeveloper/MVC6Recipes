/// <reference path="../lib/jquery/jquery.js" />
/// <reference path="../lib/jquery-ui/jquery-ui.js" />

var jswizard = (function ($) {
    "use strict"

    var _CurrentStep = 0,
        _TotalSteps = 0,
        _CanShowFinish = false,
        _selectedClass = "btn-primary",
        _defaultClass = "btn-default", 
        _backButtonSelector = "#BackButton",
        _nextButtonSelector = "#NextButton",
        _finishButtonSelector = "#FinishButton",
        _WizardDivPrefix = "#WizardStep_Div_",
        _steps =[];

    // Show the selected step and hide current step
    function ShowWizardStep(wizardStepNumber) {
        console.log("showing step " + wizardStepNumber);
        $("#WizardStep_" + _CurrentStep).removeClass(_selectedClass);
        $(_WizardDivPrefix + _CurrentStep).hide();
        $("#WizardStep_" + wizardStepNumber).addClass(_selectedClass);
        $(_WizardDivPrefix + wizardStepNumber).show().removeClass("hidden");
        _CurrentStep = wizardStepNumber;
        ShowHideButtons();
    }

    // go to the next step of the wizard
    function WizardNext() {
        if ($("#WizardForm0").valid()) {
            wizardMove(1);
        }
    }

    // go to the previous wizard step
    function WizardBack() {
        if (_CurrentStep == 0) return; // cant go back since you are at the start
        wizardMove(-1);
    }

    // moves wizard forward or backwards x number of steps
    function wizardMove(steps) {
        $("#WizardStep_" + _CurrentStep).removeClass(_selectedClass).addClass(_defaultClass);
        _steps[_CurrentStep].hide("slide", { direction: (steps>0) ? "right" : "left" },
            function () {
                _CurrentStep = _CurrentStep + steps;
                $("#WizardStep_" + _CurrentStep).addClass(_selectedClass);
                _steps[_CurrentStep].removeClass("hidden");
                _steps[_CurrentStep].show("slide", { direction: (steps < 0) ? "right" : "left" });
                ShowHideButtons();
            });
    }

    // based on the current step show or hide
    // relevant navigation
    function ShowHideButtons() {
        if (_CurrentStep == 0)
            $(_backButtonSelector).hide();
        else
            $(_backButtonSelector).show();

        if (_CurrentStep == (_TotalSteps - 1))
            $(_nextButtonSelector).hide();
        else
            $(_nextButtonSelector).show();
        if (_CurrentStep > 2)
            _CanShowFinish = true;
        if (_CanShowFinish == true)
            $(_finishButtonSelector).show();
        else
            $(_finishButtonSelector).hide();
    }

    function registerEvents() {
        $(_nextButtonSelector).click(WizardNext);
        $(_backButtonSelector).click(WizardBack);
        $("button[data-wizardstep]").click(function () {
            var stepNumber = $(this).attr("data-wizardstep");
            ShowWizardStep(stepNumber);
        });
    }

    // initialize the wizard
    // and register event handlers
    function init(options) {
        _TotalSteps = (options && options.numberOfSteps) ? options.numberOfSteps : 0;
        // additional code to update other global variables with values supplied in
        // the options argument

        console.log("Wizard initialized with " + _TotalSteps + " steps.");      
        // add each of the step divs to the div array
        var i=0;
        for (i; i < _TotalSteps; i++) {
            _steps.push($(_WizardDivPrefix + i));
        }
        ShowWizardStep(0);
        registerEvents();
    }
    // expose the init method so it can be called outside the closure
    return { init: init};
})(jQuery);