﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="http404.aspx.cs" Inherits="http404" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">

    <link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
    <style>
        .omnibox {
            border: solid .5px rgba(0,0,0,.4);
            padding: 4px;
            border-radius: 3px;
            font-size: 18px;
            display: inline-block;
            background-color: white;
        }

        .lock {
            font-size: .8em;
            color: green;
        }

        img.wha {
            padding-left: 300px;
            margin-bottom: -48px;
        }

        h1 {
            font-size: 48px;
        }

        p > sup {
            font-size: 1.15em;
            font-color: orange;
        }

        p > span {
            color: orange;
            font-size: 1.25em;
            font-weight: bold;
        }

        /* Slanted tabs on codepan - https://codepen.io/sheridanms/pen/wnvCc */
        /**
       * Slanted tabs with CSS 3D transforms
       * See http://lea.verou.me/2013/10/slanted-tabs-with-css-3d-transforms/
       */

        body {
            padding: 50px;
        }

        nav {
            position: relative;
            z-index: 1;
            white-space: nowrap;
        }

            nav a {
                position: relative;
                display: inline-block;
                padding: 1.5em 1.5em 1em;
                color: inherit;
                text-decoration: none;
                margin: 0 -7px;
            }

                nav a::before,
                main {
                    border: .1em solid #aaa;
                }

                nav a::before {
                    content: ''; /* To generate the box */
                    position: absolute;
                    top: 0;
                    right: 0;
                    bottom: .5em;
                    left: 0;
                    z-index: -1;
                    border-bottom: none;
                    border-radius: 10px 10px 0 0;
                    background: #ddd;
                    box-shadow: 0 2px hsla(0,0%,100%,.5) inset;
                    transform: perspective(5px) rotateX(2deg);
                    transform-origin: bottom;
                }

            nav.left a {
                padding: 1.5em 2em 1em 1em;
            }

                nav.left a::before {
                    transform-origin: bottom left;
                }

            nav.right a {
                padding: 1.5em 1em 1em 2em;
            }

                nav.right a::before {
                    transform-origin: bottom right;
                }

            nav a.selected {
                z-index: 2;
            }

                nav a.selected::before {
                    margin-bottom: -1px;
                    border-top-width: 1px;
                }

                nav a.selected::before,
                main {
                    background: #eee;
                }

        main {
            display: block;
            margin: -8px 0 30px -15px;
            padding: 1em;
            padding-top: 3px;
            border-radius: 3px;
        }
    </style>
    <div class="row">
        <div class="col-md-12">
            <img class="wha" src="404.png" /><br />
            <nav>
                <a href="#">Google</a>
                <a href="#" class="selected">404-U-R-Here</a>
                <a href="#">FireFox</a>
                <a href="#">Bing</a>
            </nav>
            <main>
                <div class="omnibox"><span class="lock">&nbsp;<i class="fa fa-lock">&nbsp;&nbsp;Secure</i></span> | <span id="addr"></span></div>
                <h1>404 == WTF<sup>*</sup></h1>
                <p>
                    <sup>*</sup><span>(Why That Failed?)</span>
                    It looks like I don't have any content at the page you tried to access. Not sure what you were looking for, but you can check out the <a href="/">Home</a> page to see what I have available.
                </p>
            </main>
        </div>
    </div>
    <script>
        document.getElementById('addr').innerText = document.location.href;
    </script>
</asp:Content>

