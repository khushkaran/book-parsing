require "spec_helper"
require "book_parser"

describe BookParser do

  let(:parser) { BookParser.new("../text.txt")}

  it "can be initialised with text file" do
    expect(parser.book).not_to be_nil
  end

  context "Splitting a string" do

    let(:string) { "This is simples! This will be fun!" }

    it "can split a string" do
      sample_array = ["This", "is", "simples", "This", "will", "be", "fun"]
      expect(parser.split(string)).to eq sample_array
    end

    it "can count the occurences of words" do
      occurences = {"This"=>2, "is"=>1, "simples"=>1, "will"=>1, "be"=>1, "fun"=>1}
      expect(parser.occurences(string)).to eq occurences
    end
  end
  
end