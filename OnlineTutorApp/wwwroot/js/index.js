
function showImage() {
    if (this.files && this.files[0]) {
        var obj = new FileReader();
        obj.onload = function (data) {
            var image = document.getElementById("image");
            image.src = data.target.result;
        }
        obj.readAsDataURL(this.files[0]);
    }
}

function tabContentClick() {
    let tabContentChildren = this.children;
    for (let child of tabContentChildren) {
        child.addEventListener("click", function () {
            document.getElementById("tab-content-nav").querySelector(".selected").classList.remove("selected");
            this.lastChild.classList.add("selected");
        });
    }
}

$(document).ready(function () {

    if (window.innerWidth <= 991) {
        $("#course").click(function () {
            $("#course_submenu").slideToggle("1000");
        });

        $("#categories").click(function () {
            $("#categories_submenu").slideToggle("1000");
        });
    }


    /////Comment

    $(document).on("click", "#btn_comment", function () {

        var videoId = $("#videoId").val();
        var statusCode = "";

        var commentCountTex = document.getElementById("commentCount").textContent;
        var commentCountStr = commentCountTex.split(" comments");
        var commentCount = parseInt(commentCountStr);

        var comment = $("#commentText").val();
        if (comment != '') {
            $.ajax({
                url: "/Ajax/AddComment",
                data: { commentVal: comment, videoId: videoId },
                method: "POST",
                success: function (res) {
                    statusCode = res.status;
                    if (statusCode == "200") {
                        $("#commentText").val('');
                        $.ajax({
                            url: "/Ajax/LoadComments",
                            data: { videoId: videoId },
                            method: "GET",
                            success: function (datas) {
                                $("#comments").html(datas);
                                $("#commentText").val('');
                                var newCount = commentCount + 1;
                                document.getElementById("commentCount").innerText = newCount + " comments";
                            }
                        });
                    }
                }
            });
        }
    });

    //like

    $(document).on("click", "#btn_like", function () {
        let videoId = $("#videoId").val();
        let likeCount = parseInt(document.getElementById("like_Count").textContent);
        let dislikeCount = parseInt(document.getElementById("dislike_Count").textContent);
        alert(likeCount + " " + dislikeCount);
        $.ajax({
            url: "/Ajax/Like",
            data: { videoId: videoId },
            method: "Post",
            success: function (res) {
                let statusCode = "";
                statusCode = res.status;
                if (statusCode == "200") {
                    $.ajax({
                        url: "/Ajax/LoadLikes",
                        data: { videoId: videoId },
                        method: "GET",
                        success: function (datas) {
                            $("#rating").html(datas);

                        }

                    });

                }
            }
        });

    });
    //dislike
    $(document).on("click", "#btn_dislike", function () {
        let videoId = $("#videoId").val();
        let likeCount = parseInt(document.getElementById("like_Count").textContent);
        let dislikeCount = parseInt(document.getElementById("dislike_Count").textContent);

        // alert(likeCount + " " + dislikeCount);
        $.ajax({
            url: "/Ajax/DisLike",
            data: { videoId: videoId },
            method: "Post",
            success: function (res) {
                let statusCode = "";
                statusCode = res.status;
                if (statusCode == "200") {
                    $.ajax({
                        url: "/Ajax/LoadLikes",
                        data: { videoId: videoId },
                        method: "GET",
                        success: function (datas) {
                            $("#rating").html(datas);

                        }
                    });
                }
            }
        });
    });


});