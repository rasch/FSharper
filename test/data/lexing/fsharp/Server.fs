module BroadcastConsole

open System
open System.Collections.Generic

/// Message type
type Message = string

/// Console history is a string sequence
type ConsoleHistory = ResizeArray<Message>

/// An in memory server that listens
type Server() =
    let channelHistoryMap = new Dictionary<_, ConsoleHistory>()
    let channelListeners = new Dictionary<_, Event<Message>>()
    let channelExists name = channelHistoryMap.ContainsKey(name)
    let triggerUnknownChannelExn name =
        failwith <| sprintf "Unknown channel name: %O" name

    /// Register to a channel
    member this.RegisterToChannel (channelName: string, handler: _) =
        if channelExists channelName then
            channelListeners.[channelName].Publish.Add(handler)
        else
            triggerUnknownChannelExn channelName

    /// Returns the console history of a specific channel
    member this.GetConsoleHistory (channelName: string) =
        let ok, result = channelHistoryMap.TryGetValue(channelName)
        if ok then  
            result
        else
            triggerUnknownChannelExn channelName
    
    /// Initialize a console channel
    member this.CreateChannel (channelName: string) =
        if not (channelHistoryMap.ContainsKey(channelName)) then
            channelHistoryMap.[channelName] <- new ConsoleHistory()
            channelListeners.[channelName] <- new Event<_>()

        true

    /// Broadcast a message to a particular channel
    member this.BroadcastMessage (channelName: string, msg: Message) =
        if channelExists channelName then
            channelHistoryMap.[channelName].Add(msg)
            channelListeners.[channelName].Trigger(msg)
        else
            triggerUnknownChannelExn channelName
