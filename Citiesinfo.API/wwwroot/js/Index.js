
var api = {
    city: 'api/cities'
};

var tblCities = null;

var showCities = function () {
    $.get(api.city).done(function (cities) {
        if (tblCities) {
            tblCities.clear().rows.add(cities).draw();
        } else {
            tblCities = $('#tblCities').DataTable({
                data: cities,
                columns: [
                    { data: "id" },
                    { data: "name" },
                    { data: "description" }
                ]
            });
        }

    }).fail(function (e) {
        console.error("Error while retrieving cities!");
        alert("Error while retrieving cities!");
    });
};

var saveCity = function () {
    $('#addCityModal').on('hidden.bs.modal', function (e) {
        $('#cityName').val('');
        $('#cityDescription').val('');
    });

    $('#btnSaveCity').click(function () {

        var city = {
            name: $('#cityName').val(),
            description: $('#cityDescription').val()
        };

        console.log("Adding city: " + JSON.stringify(city));

        $.ajax({
            method: 'POST',
            url: api.city,
            contentType: 'application/json',
            dataType: 'json',
            data: JSON.stringify(city)
        }).done(function (city) {
            console.log("Successfully added city: " + JSON.stringify(city));
            $('#addCityModal').modal('hide');
            showCities();
        }).fail(function (e) {
            console.error("Error while adding a city!: " + JSON.stringify(e));
            alert("Error while adding a city!: " + JSON.stringify(e));
        });

    });
};

var configurePage = function () {
    showCities();
    saveCity();
};

$(document).ready(function () {
    configurePage();
});