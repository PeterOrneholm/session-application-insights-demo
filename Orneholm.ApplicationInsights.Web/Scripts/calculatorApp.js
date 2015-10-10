(function () {

    function formatDays(days) {
        return days.toUpperCase();
    }





    var $loader = $("#loader");
    $loader.hide();

    $("form").on("submit", function formSubmit(event) {
        // Prevent default submiy
        event.preventDefault();


        // Track event
        //appInsights.trackEvent('AgeRequestSubmited');



        // Get data from form
        var dateOfBirth = $("#dateOfBirth").val();


        // Ask server for calculation
        $loader.show();
        $.getJSON("/api/age/", { dateOfBirth: dateOfBirth }, function renderResult(days) {
            $loader.hide();

            $("#output").text(formatDays(days));
            //appInsights.trackEvent('AgeCalculationDisplayed');
        });
    });
}());