USE [NebulaTravel]
GO

SET IDENTITY_INSERT dbo.Spaceships ON

INSERT INTO [dbo].[Spaceships]
           ([SpaceshipId]
		   ,[Description]
           ,[Name]
           ,[Overview]
           ,[Picture]
           ,[Constructor]
           ,[CrewCapacity]
           ,[Engines]
           ,[FirstLaunch]
           ,[Length]
           ,[PassengerCapacity]
           ,[TotalMass])
     VALUES
           (1
		   ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. </br> Sed mauris neque, ultrices ac dui ut, faucibus sollicitudin tellus. Proin et ullamcorper tortor. Ut condimentum sapien purus, at porta odio posuere ac. Morbi rhoncus eros sed magna faucibus, eu convallis nibh convallis. Donec et porttitor dui, ac iaculis tortor. Nulla lacinia vestibulum est, et interdum dui malesuada vitae. Vestibulum dictum justo vel finibus sagittis. Praesent vestibulum, urna sed congue faucibus, arcu mi imperdiet ligula, id facilisis purus est non leo. Pellentesque id lorem dignissim, gravida tellus quis, maximus massa. Sed elementum venenatis libero non dignissim. Nam viverra nunc sed posuere suscipit. '
           ,'Hyperion'
           ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. '
           ,'Hyperion.png'
           ,'SpaceX'
           ,'14'
           ,'SX-FireFly (Pulsed plasma thruster)'
           ,'12-21-29'
           ,'121 m'
           ,'70'
           ,'3014 t')
GO

INSERT INTO [dbo].[Spaceships]
           ([SpaceshipId]
		   ,[Description]
           ,[Name]
           ,[Overview]
           ,[Picture]
           ,[Constructor]
           ,[CrewCapacity]
           ,[Engines]
           ,[FirstLaunch]
           ,[Length]
           ,[PassengerCapacity]
           ,[TotalMass])
     VALUES
           (2
		   ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. </br> Sed mauris neque, ultrices ac dui ut, faucibus sollicitudin tellus. Proin et ullamcorper tortor. Ut condimentum sapien purus, at porta odio posuere ac. Morbi rhoncus eros sed magna faucibus, eu convallis nibh convallis. Donec et porttitor dui, ac iaculis tortor. Nulla lacinia vestibulum est, et interdum dui malesuada vitae. Vestibulum dictum justo vel finibus sagittis. Praesent vestibulum, urna sed congue faucibus, arcu mi imperdiet ligula, id facilisis purus est non leo. Pellentesque id lorem dignissim, gravida tellus quis, maximus massa. Sed elementum venenatis libero non dignissim. Nam viverra nunc sed posuere suscipit. '
           ,'Orpheus'
           ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. '
           ,'Orpheus.png'
           ,'European Space Agency'
           ,'25'
           ,'Magnetic sails: Module-2044'
           ,'07-11-45'
           ,'250 m'
           ,'50'
           ,'7112 t')
GO

INSERT INTO [dbo].[Spaceships]
           ([SpaceshipId]
		   ,[Description]
           ,[Name]
           ,[Overview]
           ,[Picture]
           ,[Constructor]
           ,[CrewCapacity]
           ,[Engines]
           ,[FirstLaunch]
           ,[Length]
           ,[PassengerCapacity]
           ,[TotalMass])
     VALUES
           (3
		   ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. </br> Sed mauris neque, ultrices ac dui ut, faucibus sollicitudin tellus. Proin et ullamcorper tortor. Ut condimentum sapien purus, at porta odio posuere ac. Morbi rhoncus eros sed magna faucibus, eu convallis nibh convallis. Donec et porttitor dui, ac iaculis tortor. Nulla lacinia vestibulum est, et interdum dui malesuada vitae. Vestibulum dictum justo vel finibus sagittis. Praesent vestibulum, urna sed congue faucibus, arcu mi imperdiet ligula, id facilisis purus est non leo. Pellentesque id lorem dignissim, gravida tellus quis, maximus massa. Sed elementum venenatis libero non dignissim. Nam viverra nunc sed posuere suscipit. '
           ,'Pioneer'
           ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. '
           ,'Pioneer.png'
           ,'Sierra Nevada Corporation'
           ,'2'
           ,'Boston7 (Fusion rocket)'
           ,'12-01-37'
           ,'24 m'
           ,'8'
           ,'70 t')
GO

INSERT INTO [dbo].[Spaceships]
           ([SpaceshipId]
		   ,[Description]
           ,[Name]
           ,[Overview]
           ,[Picture]
           ,[Constructor]
           ,[CrewCapacity]
           ,[Engines]
           ,[FirstLaunch]
           ,[Length]
           ,[PassengerCapacity]
           ,[TotalMass])
     VALUES
           (4
		   ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. </br> Sed mauris neque, ultrices ac dui ut, faucibus sollicitudin tellus. Proin et ullamcorper tortor. Ut condimentum sapien purus, at porta odio posuere ac. Morbi rhoncus eros sed magna faucibus, eu convallis nibh convallis. Donec et porttitor dui, ac iaculis tortor. Nulla lacinia vestibulum est, et interdum dui malesuada vitae. Vestibulum dictum justo vel finibus sagittis. Praesent vestibulum, urna sed congue faucibus, arcu mi imperdiet ligula, id facilisis purus est non leo. Pellentesque id lorem dignissim, gravida tellus quis, maximus massa. Sed elementum venenatis libero non dignissim. Nam viverra nunc sed posuere suscipit. '
           ,'Shangri-La'
           ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. '
           ,'Shangri.png'
           ,'XCOR Aerospace'
           ,'22'
           ,'XCOR Nova (Nuclear–thermal rocket)'
           ,'02-04-31'
           ,'350 m'
           ,'580'
           ,'8941 t')
GO

INSERT INTO [dbo].[Spaceships]
           ([SpaceshipId]
		   ,[Description]
           ,[Name]
           ,[Overview]
           ,[Picture]
           ,[Constructor]
           ,[CrewCapacity]
           ,[Engines]
           ,[FirstLaunch]
           ,[Length]
           ,[PassengerCapacity]
           ,[TotalMass])
     VALUES
           (5
		   ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. </br> Sed mauris neque, ultrices ac dui ut, faucibus sollicitudin tellus. Proin et ullamcorper tortor. Ut condimentum sapien purus, at porta odio posuere ac. Morbi rhoncus eros sed magna faucibus, eu convallis nibh convallis. Donec et porttitor dui, ac iaculis tortor. Nulla lacinia vestibulum est, et interdum dui malesuada vitae. Vestibulum dictum justo vel finibus sagittis. Praesent vestibulum, urna sed congue faucibus, arcu mi imperdiet ligula, id facilisis purus est non leo. Pellentesque id lorem dignissim, gravida tellus quis, maximus massa. Sed elementum venenatis libero non dignissim. Nam viverra nunc sed posuere suscipit. '
           ,'Spectre'
           ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. '
           ,'Spectre.png'
           ,'Boeing Shadow'
           ,'25'
           ,'3rd generation Warp Engine'
           ,'04-11-45'
           ,'455 m'
           ,'700'
           ,'15422 t')
GO

INSERT INTO [dbo].[Spaceships]
           ([SpaceshipId]
		   ,[Description]
           ,[Name]
           ,[Overview]
           ,[Picture]
           ,[Constructor]
           ,[CrewCapacity]
           ,[Engines]
           ,[FirstLaunch]
           ,[Length]
           ,[PassengerCapacity]
           ,[TotalMass])
     VALUES
           (6
		   ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. </br> Sed mauris neque, ultrices ac dui ut, faucibus sollicitudin tellus. Proin et ullamcorper tortor. Ut condimentum sapien purus, at porta odio posuere ac. Morbi rhoncus eros sed magna faucibus, eu convallis nibh convallis. Donec et porttitor dui, ac iaculis tortor. Nulla lacinia vestibulum est, et interdum dui malesuada vitae. Vestibulum dictum justo vel finibus sagittis. Praesent vestibulum, urna sed congue faucibus, arcu mi imperdiet ligula, id facilisis purus est non leo. Pellentesque id lorem dignissim, gravida tellus quis, maximus massa. Sed elementum venenatis libero non dignissim. Nam viverra nunc sed posuere suscipit. '
           ,'Valkyrie'
           ,'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin laoreet hendrerit enim sit amet vestibulum. Phasellus venenatis aliquet pharetra. Nunc iaculis lectus non imperdiet pretium. Vivamus ac tincidunt mauris, id eleifend mauris. Phasellus sit amet erat et quam iaculis lacinia id et diam. Curabitur eleifend nec lectus at aliquam. Aliquam ullamcorper malesuada venenatis. Vestibulum non ultricies magna, nec volutpat erat. Nullam arcu ipsum, faucibus in orci eu, imperdiet faucibus libero. Fusce condimentum dolor dui, eget finibus justo consequat eget. Vivamus consequat ligula ut neque faucibus egestas. Nullam elit augue, pellentesque et ligula at, aliquam scelerisque urna. Nulla at mi in enim commodo porttitor. Aliquam pharetra eget velit in commodo. '
           ,'Valkyrie.png'
           ,'Virgin Galactic'
           ,'7'
           ,'2nd generation Warp Engine'
           ,'02-03-38'
           ,'120 m'
           ,'50'
           ,'492 t')
GO