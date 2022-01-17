// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $.ajax({
        url: "/api/movies",
        success: function (result) {
            console.log(result)

            var html = '<ul>';
            for (var i = 0; i < result.length; i++) {
                html += '<li><a href="#" onclick="showMovie(' + result[i].id + ')">' + result[i].title + '</a></li>';
                //html += '<p>' + result[i].title + '</p>'
            }

            html += '</ul>'
           

            console.log(html)

            $('#listMovies').html(html);
        }
    });
});

function showMovie(id) {
    alert(id)

    $.ajax({
        url: '/api/movies/' + id,
        success: function (result) {
            console.log(result)

            var html = '';
            for (var i = 0; i < result.comments.length; i++) {
                html += '<p>' +  result.comments[i].text + '</p>';
                //html += '<p>' + result[i].title + '</p>'
            }

            html += '<button onclick="hideMovie()">Back</button>'

            console.log(html)

            $('#listMovies').hide();
            $('#listDetails').html(html);
            $('#listDetails').show();
        }
    });
}

function hideMovie() {
    $('#listMovies').show();
    $('#listDetails').hide();
}