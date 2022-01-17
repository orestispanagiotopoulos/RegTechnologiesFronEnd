
$(document).ready(function () {
    $.ajax({
        url: "/api/movies",
        success: function (result) {
            var html = '<p><b>' + 'List of movies' + '</b></p>';
            html += '<ul>';
            for (var i = 0; i < result.length; i++) {
                html += '<li><a href="#" onclick="showMovie(' + result[i].id + ')">' + result[i].title + '</a></li>';
            }
            html += '</ul>'

            $('#listMovies').html(html);
        }
    });
});

function showMovie(id) {

    $.ajax({
        url: '/api/movies/' + id,
        success: function (result) {

            var html = '';
            html += '<p><b>' + 'Movie details' + '</b></p>';
            html += '<p>' + 'Title: ' + result.title + '</p>';
            html += '<p>' + 'Rating: ' + result.rating + '</p>';
            html += '<p>' + 'Duration: ' + result.duration + ' min' + '</p>';
            html += '<p>' + 'Year: ' + result.year + '</p>';
            html += '<p>' + 'Popularity : ' + result.popularity + '</p>';
            html += '<hr>';
            html += '<p><b>' + 'Reviews' + '</b></p>';

            for (var i = 0; i < result.comments.length; i++) {

                var date = new Date(result.comments[i].date);

                html += '<p>' + 'Author: ' + result.comments[i].author + '</p>';
                html += '<p>' + 'Date: ' + date.toLocaleDateString() + '</p>';
                html += '<p>' + 'Comment: ' + result.comments[i].text + '</p>';
                html += '<hr>';
            }

            html += '<button onclick="hideMovie()">Back</button>'

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