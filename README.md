# UnfuckMyHeadset
automatically disable telephony service on bluetooth headsets to
stop windows from switching to your headset mic, reducing audio quality or to prevent audio stutter in games

(keep in mind that if you use this, you will need a separate microphone from the one in your headset if you still want a mic)

## why?
Often, bluetooth headsets have issues like stuttering, popping or skipping every few seconds, or even switching to low bandwidth
mode to allow use of the microphone when playing games.
Generally speaking, this is considered a bad thing.

The bluetooth device settings in windows are horribly inaccessible and take a lot of time to find
To make matters worse, every time you reboot your computer you need to find the settings again
and turn the service off because it will turn itself back on.

UnfuckMyHeadset aims to provide a one-click (or even zero click) solution to fixing that problem.

## how?
This dotnet console application enumerates your paired bluetooth devices and tries to identify
bluetooth headsets and headphones.
If any of them have the remote telephony service enabled, this service will disable them.
The program will then terminate.
