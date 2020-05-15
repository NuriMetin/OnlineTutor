
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

   //Course amount form for create action
    $(document).on("change", "#coursePaymentForm", function () {
      
        let isFree = $("#coursePaymentForm").val();
        let amount = $("#courseAmount");
        alert(isFree + " " + amount.css("display"));
        if (isFree == "false") {
            $("#courseAmount").css("display", "block");   
        }
        else
        {
            $("#courseAmount").css("display", "none");
        }
    });

    

    //Likes for courses
    let courseLikes = document.querySelectorAll(".course-like");
    for (let like of courseLikes) {
        like.firstElementChild.addEventListener("click", function () {
            let courseId = like.querySelector(".courseId").value;
            $.ajax({
                url: "/Ajax/LikeCourse",
                method: "POST",
                data: { courseId: courseId },
                success: function (res) {
                    like.lastElementChild.innerHTML = res.count;
                    like.firstElementChild.classList.remove("fas","far");
                    like.firstElementChild.classList.add(res.heart);
                }
            });
        });
    }

    /////Comment

    $(document).on("click", "#btn_comment", function () {

        let videoId = $("#videoId").val();
        let statusCode = "";
        let commentCountTex = document.getElementById("commentCount").textContent;
        let commentCountStr = commentCountTex.split(" comments");
        let commentCount = parseInt(commentCountStr);
        let comment = $("#commentText").val();

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
                                let newCount = commentCount + 1;
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
        $.ajax({
            url: "/Ajax/LikeVideo",
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
        $.ajax({
            url: "/Ajax/DisLikeVideo",
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