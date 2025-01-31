var get_id;
function shoemsg(id) {
    get_id = id;
    $('#del').modal('show')

}
function DeleteTicket() {
    $.ajax(
        {
            url: 'DeleteTicket',
            type: "get",
            data: { id: get_id },

            success: function (result) {


                alert('تم الحذف بنجاح');
                $("#categoreisContainer").html(result)

            }

        }
    );

}
function shoemsgupdate(id) {
    get_id = id;
    var id1 = document.getElementById("Id1");
    var name = document.getElementById("Name1");
    var location = document.getElementById("Location1");
    $.ajax(
        {
            url: 'getstationdata',
            type: "get",
            data: { id: get_id },

            success: function (result) {
               
                name.innerHTML = result.name;
                console.table(result);
                $('#update').modal('show')
               // $("#categoreisContainer").html(result)

            }

        }
    );
  

}
function confirm_deletstation() {
    $.ajax(
        {
            url: 'DeleteStation',
            type: "get",
            data: { id: get_id },

            success: function (result) {
               

                alert('تم الحذف بنجاح');
                $("#categoreisContainer").html(result)

            }

        }
    );

}




function confirm_updatestation() {

    $.ajax(
        {
            url: 'UpdateStation',
            type: "get",
            data: { id: get_id },

            success: function (result) {


                alert('تم التعديل بنجاح');
                $("#categoreisContainer").html(result)

            }

        }
    );

}