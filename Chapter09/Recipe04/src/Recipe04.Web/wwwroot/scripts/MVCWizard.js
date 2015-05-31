﻿var wizard = (function () {
    "use strict";
    function WizardSubmit(action, formId) {
        if (undefined == formId)
            formId = 0;
        document.forms[formId].action =  action;
        document.forms[formId].submit();
    }

    return {
        WizardSubmit: WizardSubmit
    }
})();