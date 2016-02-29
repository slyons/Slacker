module SlackerStepDefinitions

open System
open Slacker.API
open TickSpec
open NUnit.Framework

let mutable command = ["none"; "none"]

let [<Given>] ``a slacker bot`` () = 
    ()

let [<When>] ``I issue command "(.*)"`` (com:string)=
    command <- com.Split(' ') |> Array.toList

let [<Then>] ``it should reply "(.*)"`` (expected:string) =
    let response = ProcessRequest command
    match response with
    | PublicResponse(s) -> Assert.AreEqual(expected, s)
    | _ -> Assert.Fail()