##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Debug
ProjectName            :=phonebook
ConfigurationName      :=Debug
WorkspaceConfiguration := $(ConfigurationName)
WorkspacePath          :=F:/C++/C++/C++
ProjectPath            :=F:/C++/C++/C++/phonebook
IntermediateDirectory  :=../build-$(ConfigurationName)/phonebook
OutDir                 :=../build-$(ConfigurationName)/phonebook
CurrentFileName        :=
CurrentFilePath        :=
CurrentFileFullPath    :=
User                   :=LAPTOP
Date                   :=08/05/2022
CodeLitePath           :="C:/Program Files/CodeLite"
LinkerName             :=F:/C++/mingw64/bin/g++.exe
SharedObjectLinkerName :=F:/C++/mingw64/bin/g++.exe -shared -fPIC
ObjectSuffix           :=.o
DependSuffix           :=.o.d
PreprocessSuffix       :=.i
DebugSwitch            :=-g 
IncludeSwitch          :=-I
LibrarySwitch          :=-l
OutputSwitch           :=-o 
LibraryPathSwitch      :=-L
PreprocessorSwitch     :=-D
SourceSwitch           :=-c 
OutputFile             :=..\build-$(ConfigurationName)\bin\$(ProjectName)
Preprocessors          :=
ObjectSwitch           :=-o 
ArchiveOutputSwitch    := 
PreprocessOnlySwitch   :=-E
ObjectsFileList        :=$(IntermediateDirectory)/ObjectsList.txt
PCHCompileFlags        :=
RcCmpOptions           := 
RcCompilerName         :=F:/C++/mingw64/bin/windres.exe
LinkOptions            :=  
IncludePath            :=  $(IncludeSwitch). $(IncludeSwitch). 
IncludePCH             := 
RcIncludePath          := 
Libs                   := 
ArLibs                 :=  
LibPath                := $(LibraryPathSwitch). 

##
## Common variables
## AR, CXX, CC, AS, CXXFLAGS and CFLAGS can be overriden using an environment variables
##
AR       := F:/C++/mingw64/bin/ar.exe rcu
CXX      := F:/C++/mingw64/bin/g++.exe
CC       := F:/C++/mingw64/bin/gcc.exe
CXXFLAGS :=  -g -O0 -Wall $(Preprocessors)
CFLAGS   :=  -g -O0 -Wall $(Preprocessors)
ASFLAGS  := 
AS       := F:/C++/mingw64/bin/as.exe


##
## User defined environment variables
##
CodeLiteDir:=C:\Program Files\CodeLite
Objects0=../build-$(ConfigurationName)/phonebook/PhoneDirectory.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/phonebook/main.cpp$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild MakeIntermediateDirs
all: MakeIntermediateDirs $(OutputFile)

$(OutputFile): ../build-$(ConfigurationName)/phonebook/.d $(Objects) 
	@if not exist "..\build-$(ConfigurationName)\phonebook" mkdir "..\build-$(ConfigurationName)\phonebook"
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(LinkerName) $(OutputSwitch)$(OutputFile) @$(ObjectsFileList) $(LibPath) $(Libs) $(LinkOptions)

MakeIntermediateDirs:
	@if not exist "..\build-$(ConfigurationName)\phonebook" mkdir "..\build-$(ConfigurationName)\phonebook"
	@if not exist ""..\build-$(ConfigurationName)\bin"" mkdir ""..\build-$(ConfigurationName)\bin""

../build-$(ConfigurationName)/phonebook/.d:
	@if not exist "..\build-$(ConfigurationName)\phonebook" mkdir "..\build-$(ConfigurationName)\phonebook"

PreBuild:


##
## Objects
##
../build-$(ConfigurationName)/phonebook/PhoneDirectory.cpp$(ObjectSuffix): PhoneDirectory.cpp ../build-$(ConfigurationName)/phonebook/PhoneDirectory.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "F:/C++/C++/C++/phonebook/PhoneDirectory.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/PhoneDirectory.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/phonebook/PhoneDirectory.cpp$(DependSuffix): PhoneDirectory.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/phonebook/PhoneDirectory.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/phonebook/PhoneDirectory.cpp$(DependSuffix) -MM PhoneDirectory.cpp

../build-$(ConfigurationName)/phonebook/PhoneDirectory.cpp$(PreprocessSuffix): PhoneDirectory.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/phonebook/PhoneDirectory.cpp$(PreprocessSuffix) PhoneDirectory.cpp

../build-$(ConfigurationName)/phonebook/main.cpp$(ObjectSuffix): main.cpp ../build-$(ConfigurationName)/phonebook/main.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "F:/C++/C++/C++/phonebook/main.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/main.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/phonebook/main.cpp$(DependSuffix): main.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/phonebook/main.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/phonebook/main.cpp$(DependSuffix) -MM main.cpp

../build-$(ConfigurationName)/phonebook/main.cpp$(PreprocessSuffix): main.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/phonebook/main.cpp$(PreprocessSuffix) main.cpp


-include ../build-$(ConfigurationName)/phonebook//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


