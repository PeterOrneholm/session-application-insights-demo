(function () {

    // Format days in a nice way
    function formatDays(days) {
        return days.toUpperCase();
    }



    var $loader = $("#loader");
    $loader.hide();

    $("form").on("submit", function formSubmit(event) {
        // Prevent default submiy
        event.preventDefault();


        // Get data from form
        var dateOfBirth = $("#dateOfBirth").val();


        // Ask server for calculation
        $loader.show();

        appInsights.trackEvent("CalculatingAge", { dateOfBirth: dateOfBirth });

        $.getJSON("/api/age/", { dateOfBirth: dateOfBirth }).then(function renderResult(days) {
            $loader.hide();

            $("#output").text(formatDays(days));
        }, function (error) {
            appInsights.trackException(error.responseJSON.ExceptionMessage, "Age calculator", { dateOfBirth: dateOfBirth });
        });
    });
}());