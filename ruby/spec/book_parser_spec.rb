require "spec_helper"
require "book_parser"

describe BookParser do

  let(:parser) { BookParser.new("../text.txt")}

  it "can be initialised with text file" do
    expect(parser.book).not_to be_nil
  end

  context "Splitting a string" do
    it "can split a string" do
      sample_string = "This is simples! This will be fun!"
      sample_array = ["This", "is", "simples", "This", "will", "be", "fun"]
      expect(parser.split(sample_string)).to eq sample_array
    end
  end
  
end