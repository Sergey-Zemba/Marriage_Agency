$(document).ready(function () {
    $(".homeCinema .delete").click(function (event) { remove(event); });
});

function remove(event) {
    event.preventDefault();
    var device = $(event.target).closest(".photoItem")[0];
    var id = $(device).find(".hidden").val();
    $.ajax({
        url: "/FilePath/Delete/" + id,
        type: "DELETE",
        success: function () {
            var container = $(event.target).closest(".photoContainer")[0];
            container.removeChild(device);
        }
    });
}
